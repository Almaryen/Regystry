using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;

[TableName("Вулиці дільниць")]
public class DISTRICT_STREET_Metadata
{
    [Description("Вулиця")]
    [DisplayName("Вулиця")]
    public int STREET_ID { get; set; }

    [Description("Вікова категорія дільниці")]
    [DisplayName("Вікова категорія дільниці")]
    public int MEDDISTRICT_AGECATEGORY_ID { get; set; }

    [Description("Номер будинку")]
    [DisplayName("Номер будинку")]
    public string NUM_STREET { get; set; }

    [Description("Вікові категорії дільниць")]
    [DisplayName("Вікові категорії дільниць")]
    public EntityRef<MEDDISTRICT_AGECATEGORY> MEDDISTRICT_AGECATEGORY { get; set; }


    [Description("Вулиці")]
    [DisplayName("Вулиці")]
    public EntityRef<STREET> STREET { get; set; }

}







    


    
