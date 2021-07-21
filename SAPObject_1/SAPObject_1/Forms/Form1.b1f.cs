using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;
using SAPObject_1.Controllers;

namespace SAPObject_1
{
    [FormAttribute("SAPObject_1.Form1", "Forms/Form1.b1f")]
    class Form1 : UserFormBase
    {
        public Form1()
        {
        }

        private SetupFormController _controller { get; set; }
        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_0").Specific));
            this.Button0.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.Button0_PressedAfter);
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_1").Specific));
            this.Button1.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.Button1_PressedAfter);
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {

        }

        private SAPbouiCOM.Button Button0;

        private void OnCustomInitialize()
        {
            _controller = new SetupFormController(RSM.Core.SDK.DI.DIApplication.Company, UIAPIRawForm, new Services.SetupService());
        }

        private SAPbouiCOM.Button Button1;

        private void Button0_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            var pBar = new RSM.Core.SDK.UI.ProgressBar.ProgressBarManager(SAPbouiCOM.Framework.Application.SBO_Application, "", 1);
            try
            {
                _controller.InitDatabase();
                pBar.Stop();
                pBar.Dispose();
                RSM.Core.SDK.UI.UIApplication.ShowSuccess("Success");
            }
            catch (Exception ex)
            {
                var message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                RSM.Core.SDK.UI.UIApplication.ShowError(message);
            }
            finally
            {
                pBar.Stop();
                pBar.Dispose();
            }
        }

        private void Button1_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            UIAPIRawForm.Close();
        }
    }
}