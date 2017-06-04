using log4net;
using STDiag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDDiag
{
    class Util
    {
        private static readonly ILog Log = LogManager.GetLogger("Native");
        

        public void UpdateLogbox (string message, string logboxname)
        {
            switch (logboxname)
            {
                case "dmLogBox":
                    
                    break;
            }
        }
    }
}
