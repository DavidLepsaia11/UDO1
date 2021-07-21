using RSM.Core.SDK.Attributes;
using RSM.Core.SDK.DI.Models;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPObject_1.Models.Personal_Info
{
    [Table(Name = TableNames.persInfoModel, Description = "Personal information", Type = BoUTBTableType.bott_MasterData)]
      public class Personal_infoModel : MasterDataUDO
    {
        [Field(Name = "ID", Description = "ID", Type = BoFieldTypes.db_Alpha, Size = 11)]
        public string ID { get; set; }

        [Field(Name = "FirstName", Description = "First Name", Type = BoFieldTypes.db_Alpha, Size = 30)]
        public string FirstName { get; set; }

        [Field(Name = "LastName", Description = "Last Name", Type = BoFieldTypes.db_Alpha, Size = 40)]
        public string Currency { get; set; }

        [Field(Name = "BirthDate", Description = "Birthdate", Type = BoFieldTypes.db_Date)]
        public DateTime BirthDate { get; set; }

        public IList<Personal_infoLineModel> Personal_infoLines { get; set; }


        public Personal_infoModel()
        {
            Personal_infoLines = new List<Personal_infoLineModel>();
        }
    }



    [Table(Name = TableNames.persInfoLine, Description = "Personal information Lines", Type = BoUTBTableType.bott_MasterDataLines)]
       public class Personal_infoLineModel : MasterDataLineUDO
    {
        [Field(Name = "Age", Description = "Age", Type = BoFieldTypes.db_Numeric, Size = 3)]
        public int Age { get; set; }

        [Field(Name = "Education", Description = "Education", Type = BoFieldTypes.db_Alpha, Size = 100)]
        public string Education { get; set; }

        [Field(Name = "Zodiac", Description = "Zodiac", Type = BoFieldTypes.db_Alpha, Size = 20)]
        public string Zodiac { get; set; }


        [Field(Name = "Address", Description = "Address", Type = BoFieldTypes.db_Alpha, Size = 100)]
        public string Address { get; set; }

        [Field(Name = "Email", Description = "E-mail", Type = BoFieldTypes.db_Alpha, Size = 50)]
        public string Email { get; set; }

        [Field(Name = "MaritalStatus", Description = "Marital Status", Type = BoFieldTypes.db_Alpha, Size = 50)]
        public string MaritalStatus { get; set; }

        [Field(Name = "EmploymentStatus", Description = "Employment Status", Type = BoFieldTypes.db_Alpha, Size = 50)]
        public string EmploymentStatus { get; set; }
    }
}
