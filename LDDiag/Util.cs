using log4net;
using STDiag;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace LDDiag
{
    class Util
    {
        private static readonly ILog NativeLogger = log4net.LogManager.GetLogger("Native");
        private static readonly ILog UtilLogger = log4net.LogManager.GetLogger("Util");
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

        public static void DMLogBox(string message)
        {
            message = message + System.Environment.NewLine;
            MainWindow.dmLogBox.AppendText(message);
        }
    }

}
