using log4net;
using LDDiag;
using System;
using System.Xml;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

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
                UtilLogger.Info("XML Loaded");
            else
                UtilLogger.Error("XML not found");

            return xdoc;

        }

        public static void createRegKey(string path, string name, string value, string type)
        {
            try
            {
                RegistryKey regkey = Registry.LocalMachine.CreateSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree);
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

        public static void createEncryptedRegKeyString(string path, string name, string value)
        {
            try
            {
                RegistryKey regkey = Registry.LocalMachine.CreateSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree);
                try
                {
                    regkey.SetValue(name, value);

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
        public static void SecureSerialize<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                UtilLogger.Error("Failed to serialize settings. Exception: " + ex.Data.ToString());
            }
            try
            {
                File.Encrypt(fileName);
            }
            catch
            {
                UtilLogger.Error("Failed to encrypt file " + fileName);
            }
        }

        public T SecureDeSerialize<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                File.Decrypt(fileName);
            }
            catch (Exception ex)
            {
                UtilLogger.Error("Failed to decrypt file " + fileName + " : " + ex.Data.ToString());

            }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception ex)
            {
                UtilLogger.Error("Failed to deserialize settings. Exception: " + ex.Data.ToString());
            }

            return objectOut;
        }



    }



}
