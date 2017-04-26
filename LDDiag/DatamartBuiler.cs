using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDDiag
{
    class DatamartBuiler
    {
        String DMSource, SCNSource;
        Boolean isBackedUp;

        public DatamartBuiler(String _DMSource, String _SCNSource, Boolean _isBackedUp)
        {
            DMSource = _DMSource;
            SCNSource = _SCNSource;
            isBackedUp = _isBackedUp;
        }


    }
}
