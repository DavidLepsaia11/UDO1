using RSM.Core.SDK.Attributes;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPObject_1.Models.Personal_Info
{
    [Object(ObjectCode = UdoObjects.Personal_infoUdoObject, ObjectDescription = "Personal information", Name = UdoNames.Personal_infoUDO, Type = BoUDOObjType.boud_MasterData)]
    public class Personal_infoUDO : RSM.Core.SDK.DI.Models.Object
    {

        [Field(Name = TableNames.persInfoLine)]
        public virtual Personal_infoLineModel Personal_infoLines { get; set; }
    }
}
