using log4net;
using STDiag;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LDDiag
{

    class DatamartChecker
    {
        String DMPath, SCNPath, option;
        Boolean doBackup, doRestart, doValidate;
        private static readonly ILog DMLog = log4net.LogManager.GetLogger("DatamartBuilder");

        XmlDocument dmxml;

        public DatamartChecker(String DMPath, String SCNPath, String option, Boolean doValidate, Boolean doBackup, Boolean doRestart)
        {
            this.DMPath = DMPath;
            this.SCNPath = SCNPath;
            this.option = option;
            this.doBackup = doBackup;
            this.doRestart = doRestart;
            this.doValidate = doValidate;
            dmxml = Util.readXML(DMPath);

            route();
        }

        private void route()
        {
            switch (option)
            {
                case "Standard":
                    StandardChanges();
                    break;

                default:
                    DMLog.Error("No option specified for DatamartChecker");
                    break;
            }
        }

        private void GetSCNFromEventVwr()
        {//Query event viewer for 4100 errors where description includes "Increased Column Size May Be Necessary"

        }
        private void CompareToSCN()
        {//Compare datamart to SCN using known attribute links in changes.assoc

        }
        private void UpdateDatamart()
        {//Update datamaet nodes that don't match needed length in .SCN file

        }
        private void CommitToDB()
        {//run coreDBUtil.exe with /xml switch and Datamart.xml path

        }
        private void StandardChanges()
        {//Make all changes in StandardChanges table

            var stringWriter = new StringWriter();
            var xmlTextWriter = XmlWriter.Create(stringWriter);

               // dmxml.WriteTo(xmlTextWriter);
               // xmlTextWriter.Flush();
            

            //Util.DMLogBox("All XML:");
            //Util.DMLogBox(stringWriter.GetStringBuilder().ToString());

           // XmlNodeList root = dmxml.SelectNodes("/root");
           // Util.DMLogBox(root.Count.ToString());
            XmlNode node = dmxml.SelectSingleNode("/table[@name='\"Printer\"']");
            //Util.DMLogBox(nodes.Count.ToString());
            try
            {

                // string affectedTable = nodes.Item(0).InnerXml;

                node.WriteContentTo(xmlTextWriter);
                xmlTextWriter.Flush();
                Util.DMLogBox(stringWriter.ToString());
            }
            catch (NullReferenceException nulle)
            {
                Util.DMLogBox(nulle.Data.ToString());
            }
        }
        private void KitchenSink()
        {//Go through all functions

        }
        private void BackupDatamart()
        {//Make a backup of Datamart.xml called Datamart.bak before going further

        }
        private void RestartServices()
        {//Restart all landesk services

        }
        private void ValidateChanges()
        {//Copy specified .SCN file into ldscan and query event viewer for all Errors containing .SCN filename. Log out of sync warning if Warning is found in event viewer

        }
    }
}
