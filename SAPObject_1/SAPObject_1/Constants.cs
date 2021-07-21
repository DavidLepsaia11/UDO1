using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPObject_1
{
    public class Constants
    {
        public static readonly string Personal_InfoUDOAddRowID = "costsUDOAddRowID";
        public static readonly string Personal_InfoUDORemoveRowID = "costsUDORemoveRowID";   
    }
    public class TableNames
    {
        public const string persInfoModel = "RSM_PERINF";
        public const string persInfoLine = "RSM_PERINF1";
    }

    public class UdoNames
    {
        public const string Personal_infoUDO = "RSM_PERINF";
    }

    public class UdoObjects
    {
        public const string Personal_infoUdoObject = "PerInf";
    }

}
