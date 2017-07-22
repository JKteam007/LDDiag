using log4net;
using STDiag;
using System;
using System.Xml;
using Microsoft.Win32;
using System.Windows.Forms;

namespace LDDiag
{
    class Util
    {
        private static readonly ILog NativeLogger = log4net.LogManager.GetLogger("Native");
        private static readonly ILog UtilLogger = log4net.LogManager.GetLogger("Util");
        Form mainform = Application.OpenForms["Mainwindow"];
        public static XmlDocument readXML(string xmlPath)
        {

            XmlDocument xdoc = new XmlDocument();

            try
            {

                xdoc.Load(xmlPath);
            }
            catch (Exception e)
            {
                UtilLogger.Error(e.Data.ToString());
            }

            if (xdoc.ToString() != null)
                UtilLogger.Info("Datamart Loaded");
            else
                UtilLogger.Error("Datamart not found");

            return xdoc;

        }

        public static void createRegKey(string path, string name, string value, string type)
        {
            try
            {
                RegistryKey regkey = Registry.LocalMachine.CreateSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree);
                try
                {
                    if(type.ToUpper().Equals("DWORD", StringComparison.Ordinal))
                    {
                        UInt32 dVal;

                        if(UInt32.TryParse(value, out dVal))
                        regkey.SetValue(name, dVal, RegistryValueKind.DWord);
                    }
                    else
                    {
                        regkey.SetValue(name, value);
                    }
                }
                catch (Exception ey)
                {
                    NativeLogger.Error(ey.Data.ToString());
                    UtilLogger.Error("Failed to set value of " + name + " at registry path HKLM" + path);
                }
            }
            catch (Exception ex)
            {
                NativeLogger.Error(ex.Data.ToString());
                UtilLogger.Error("Error occured attemtping to create registry key: HKLM" + path);
            }
           

        }
        public static void setRegKey(string path, string name, string value, string type)
        {
            try
            {
                RegistryKey regkey = Registry.LocalMachine.OpenSubKey(path, true);

                try
                {
                    if (type.ToUpper().Equals("DWORD", StringComparison.Ordinal))
                    {
                        UInt32 dVal;

                        if (UInt32.TryParse(value, out dVal))
                            regkey.SetValue(name, dVal, RegistryValueKind.DWord);
                    }
                    else
                    {
                        regkey.SetValue(name, value);
                    }
                }
                catch (Exception ey)
                {
                    NativeLogger.Error(ey.Data.ToString());
                    UtilLogger.Error("Failed to set value of " + name + " at registry path HKLM" + path);
                }
            }
            catch (Exception ex)
            {
                NativeLogger.Error(ex.Data.ToString());
                UtilLogger.Error("An error occured attempting to open " + path);
            }
            
        }
        public static string getRegKey(string path, string name, string type)
        {
            
            RegistryKey regkey = Registry.LocalMachine.OpenSubKey(path);

            string val = "";

            if (regkey.GetValue(name) as string == null)
            {
                if (type.ToUpper().Equals("DWORD", StringComparison.Ordinal))
                {
                    val = regkey.GetValue(name, RegistryValueKind.DWord).ToString();
                }
            }
            else
            {
                val = regkey.GetValue(name) as string;
            }

            return val;
        }
    }

}
