using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;


[TableName("Пацієнти")]
public class PATIENT_Metadata
{


    public string FIRSTNAME { get; set; }

    public string MIDDLENAME { get; set; }

    public string LASTNAME { get; set; }

    public System.Nullable<System.DateTime> BIRTHDATE { get; set; }

    public string HOMETEL { get; set; }

    public string MOBTEL { get; set; }

    public System.Nullable<int> SEX { get; set; }

    public string EMAIL { get; set; }

    public int MEDDISTRICT_ID { get; set; }

    public int REG_ID { get; set; }

    public int DISTR_ID { get; set; }

    public int SETTL_ID { get; set; }

    public string HOUSE { get; set; }

    public string SECTION { get; set; }

    public string FLAT { get; set; }

    public EntitySet<USSER> USSERs { get; set; }

    public EntitySet<RECEPTION> RECEPTIONs { get; set; }

    public EntityRef<DISTRICT> DISTRICT { get; set; }

    public EntityRef<REGION> REGION { get; set; }

    public EntityRef<SETTLEMENT> SETTLEMENT { get; set; }

    public EntityRef<MEDDISTRICT> MEDDISTRICT { get; set; }
}




//[TableName("Вікові категорії дільниць")]
//public class MEDDISTRICT_AGECATEGORY_Metadata
//{
//    [Description("Дільниця")]
//    [DisplayName("Дільниця")]
//    public int MEDDISTRICT_ID { get; set; }


//    [Description("Вік паціентів")]
//    [DisplayName("Вік паціентів")]
//    public string AGE { get; set; }

//    private EntitySet<DISTRICT_STREET> DISTRICT_STREETs { get; set; }

//    [Description("Дільниця")]
//    [DisplayName("Дільниця")]
//    public EntityRef<MEDDISTRICT> MEDDISTRICT { get; set; }

//}





