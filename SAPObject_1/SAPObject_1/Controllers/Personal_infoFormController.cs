using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPObject_1.Controllers
{
    public class Personal_infoFormController : BaseFormController
    {
        #region Properties

        public Matrix Matrix { get { return (Matrix)Form.Items.Item("Item_0").Specific; } }

        public DBDataSource PERINF { get { return Form.DataSources.DBDataSources.Item("@RSM_PERINF"); } }
        public DBDataSource PERINF1 { get { return Form.DataSources.DBDataSources.Item("@RSM_PERINF1"); } }

        #endregion


        public Personal_infoFormController(SAPbobsCOM.Company Company, IForm Form) : base(Company, Form)
        {

        }


        public override void InitForm()
        {
            //throw new NotImplementedException();
        }

        public override void SetAutoManagedAttributes()
        {
            //throw new NotImplementedException();
        }

        #region Helper Methods
        internal void AddRow()
        {
            PERINF1.Clear();
            Matrix.AddRow(1);
            if (Form.Mode != BoFormMode.fm_ADD_MODE)
                Form.Mode = BoFormMode.fm_UPDATE_MODE;
        }
        internal void RemoveRow(int lastClickedRowIndex)
        {
            PERINF1.Clear();
            Matrix.DeleteRow(lastClickedRowIndex);
            if (Form.Mode != BoFormMode.fm_ADD_MODE)
                Form.Mode = BoFormMode.fm_UPDATE_MODE;
        }
        #endregion

    }
}
