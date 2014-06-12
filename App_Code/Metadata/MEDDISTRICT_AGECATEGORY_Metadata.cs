
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;


[TableName("Вікові категорії дільниць")]
public class MEDDISTRICT_AGECATEGORY_Metadata
{
    [Description("Дільниця")]
    [DisplayName("Дільниця")]
    public int MEDDISTRICT_ID { get; set; }


    [Description("Вік паціентів")]
    [DisplayName("Вік паціентів")]
    public System.Nullable<int> START_AGE{ get; set; }
    [Description("Вік паціентів")]
    [DisplayName("Вік паціентів")]
    public System.Nullable<int> STOP_AGE{ get; set; }

    private EntitySet<DISTRICT_STREET> DISTRICT_STREETs { get; set; }

    [Description("Дільниця")]
    [DisplayName("Дільниця")]
    public EntityRef<MEDDISTRICT> MEDDISTRICT { get; set; }

}





