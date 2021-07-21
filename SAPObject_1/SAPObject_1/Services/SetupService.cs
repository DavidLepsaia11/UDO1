using RSM.Core.SDK.DI.DAO;
using SAPObject_1.Models.Personal_Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPObject_1.Services
{
    class SetupService
    {
        //Table
        private TableDAO<Personal_infoModel> Personal_infoObjectModel;

        //Table Lines
        private TableDAO<Personal_infoLineModel> Personal_infoLineObjectModel;
     
        //UDOs
        private ObjectDAO<Personal_infoUDO> mObjPersonal_infoUDO;
       

        //UDFs
        //private SAPObjectDAO<OPCHFormUDFsModel> mObjoOPCHFormUDF;
        //private SAPObjectDAO<OJDTFormUDFsModel> mObjoOJDTFormUDF;

        public SetupService()
        {
            //Table
            Personal_infoObjectModel = new TableDAO<Personal_infoModel>();

            //Table Lines
            Personal_infoLineObjectModel = new TableDAO<Personal_infoLineModel>();

            //UDOs
            mObjPersonal_infoUDO = new ObjectDAO<Personal_infoUDO>();

           //UDFs
           //mObjoOPCHFormUDF = new SAPObjectDAO<OPCHFormUDFsModel>();
           // mObjoOJDTFormUDF = new SAPObjectDAO<OJDTFormUDFsModel>();
        }

        public void InitializeDatabase()
        {
            //Table
            Personal_infoObjectModel.Initialize();

            //Table Lines
            Personal_infoLineObjectModel.Initialize();

            //UDOs
            mObjPersonal_infoUDO.Initialize();

            //UDFs
            //mObjoOPCHFormUDF.InitializeUserFields();
            //mObjoOJDTFormUDF.InitializeUserFields();
        }
    }
}
