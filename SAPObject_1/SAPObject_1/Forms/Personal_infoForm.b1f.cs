using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using SAPObject_1.Controllers;

namespace SAPObject_1.Forms
{
    [FormAttribute("SAPObject_1.Forms.Personal_infoForm", "Forms/Personal_infoForm.b1f")]
    class Personal_infoForm : UserFormBase
    {
        public Personal_infoFormController controller { get; set; }
        public Personal_infoForm()
        {
        }
        private int lastClickedRowIndex;


        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_0").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_1").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_3").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_5").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_8").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_9").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_10").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_11").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("Item_12").Specific));
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_7").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Matrix Matrix0;

        private void OnCustomInitialize()
        {
            controller = new Personal_infoFormController(RSM.Core.SDK.DI.DIApplication.Company, UIAPIRawForm);

            SAPbouiCOM.Framework.Application.SBO_Application.RightClickEvent += this.SBO_Application_RightClickEvent;
            SAPbouiCOM.Framework.Application.SBO_Application.MenuEvent += this.SBO_Application_MenuEvent;
        }

        private void SBO_Application_RightClickEvent(ref SAPbouiCOM.ContextMenuInfo eventInfo, out bool BubbleEvent)
        {
            BubbleEvent = true;

            try
            {
                if (eventInfo.FormUID == UIAPIRawForm.UniqueID)
                {
                    var menuIdToAdd = "";
                    var menuIdToRemove = "";

                    if (eventInfo.ItemUID == controller.Matrix.Item.UniqueID)
                    {
                        menuIdToAdd = Constants.Personal_InfoUDOAddRowID;
                        menuIdToRemove = Constants.Personal_InfoUDORemoveRowID;
                    }

                    SAPbouiCOM.MenuItem oMenuItem = SAPbouiCOM.Framework.Application.SBO_Application.Menus.Item("1280");
                    SAPbouiCOM.Menus oMenus = oMenus = oMenuItem.SubMenus;

                    if (eventInfo.BeforeAction == true && eventInfo.ItemUID == controller.Matrix.Item.UniqueID)
                    {
                        SAPbouiCOM.MenuCreationParams oCrationPackage = (SAPbouiCOM.MenuCreationParams)SAPbouiCOM.Framework.Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams);

                        lastClickedRowIndex = eventInfo.Row;

                        oCrationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                        oCrationPackage.UniqueID = menuIdToAdd;
                        oCrationPackage.String = "Add Row";
                        oCrationPackage.Enabled = true;

                        if (!oMenus.Exists(menuIdToAdd))
                            oMenus.AddEx(oCrationPackage);

                        oCrationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                        oCrationPackage.UniqueID = menuIdToRemove;
                        oCrationPackage.String = "Remove Row";
                        oCrationPackage.Enabled = true;

                        if (!oMenus.Exists(menuIdToRemove))
                            oMenus.AddEx(oCrationPackage);
                    }
                    else
                    {
                        if (oMenus.Exists(menuIdToAdd))
                            oMenus.RemoveEx(menuIdToAdd);

                        if (oMenus.Exists(menuIdToRemove))
                            oMenus.RemoveEx(menuIdToRemove);
                    }
                }
            }
            catch (Exception ex)
            {
                SAPbouiCOM.Framework.Application.SBO_Application.MessageBox(ex.Message);
            }
        }
        private void SBO_Application_MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                if (Application.SBO_Application.Forms.ActiveForm.UniqueID == UIAPIRawForm.UniqueID)
                {
                    if (pVal.MenuUID == Constants.Personal_InfoUDOAddRowID && pVal.BeforeAction)
                    {
                        controller.AddRow();
                    }
                    if (pVal.MenuUID == Constants.Personal_InfoUDORemoveRowID && !pVal.BeforeAction)
                    {
                        controller.RemoveRow(lastClickedRowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                SAPbouiCOM.Framework.Application.SBO_Application.MessageBox(ex.Message);
            }
        }

        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.Folder Folder0;
    }
}
