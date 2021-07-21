using SAPbouiCOM;
using SAPObject_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPObject_1.Controllers
{
    class SetupFormController : BaseFormController
    {
        public SetupService SetupService { get; set; }

        public SetupFormController(SAPbobsCOM.Company Company, IForm Form, SetupService SetupService) : base(Company, Form)
        {
            this.SetupService = SetupService;
        }

        public void InitDatabase()
        {
            SetupService.InitializeDatabase();
        }

        public override void InitForm()
        {
            //throw new NotImplementedException();
        }

        public override void SetAutoManagedAttributes()
        {
            //throw new NotImplementedException();
        }
    }
}
