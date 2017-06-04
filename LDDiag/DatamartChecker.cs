using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDDiag
{

    class DatamartChecker
    {
        String DMPath, SCNPath, option;
        Boolean doBackup, doRestart, doValidate;
        private static readonly ILog Log = log4net.LogManager.GetLogger("DatamartBuilder");

        public DatamartChecker(String DMPath, String SCNPath, String option, Boolean doValidate, Boolean doBackup, Boolean doRestart)
        {
            this.DMPath = DMPath;
            this.SCNPath = SCNPath;
            this.option = option;
            this.doBackup = doBackup;
            this.doRestart = doRestart;
            this.doValidate = doValidate;
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
