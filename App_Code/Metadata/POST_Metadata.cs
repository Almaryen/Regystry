using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;


[TableName("Посади")]
public class POST_Metadata
{
    [Description("Професія")]
    [DisplayName("Професія")]
    public int MEDPROF_ID { get; set; }

    [ScaffoldColumn(false)]
    [Description("Відділення")]
    [DisplayName("Відділення")]
    public int DEPART_ID { get; set; }

    [Description("Персонал")]
    [DisplayName("Персонал")]
    public int PERSONAL_ID { get; set; }

    [ScaffoldColumn(false)]
    [Description("Прийом")]
    [DisplayName("Прийом")]
    public EntitySet<RECEPTION> RECEPTIONs { get; set; }

    [Description("Графік рийому")]
    [DisplayName("Графік рийому")]
    public EntitySet<SCHEDULE_DOC> SCHEDULE_DOCs{ get; set; }

    [Description("Шаблону графіку рийому")]
    [DisplayName("Шаблону графіку рийому")]
    public EntitySet<TEMPLATEGRAFTIME> TEMPLATEGRAFTIMEs { get; set; }

    [ScaffoldColumn(false)]
    [Description("Дільниці")]
    [DisplayName("Дільниці")]
    public EntitySet<MEDDISTRICT> MEDDISTRICTs { get; set; }


    [Description("Професія")]
    [DisplayName("Професія")]
    public EntityRef<MED_PROFESSION> MED_PROFESSION { get; set; }
   
    [Description("Відділення")]
    [DisplayName("Відділення")]
    public EntityRef<DEPARTAMENT> DEPARTAMENT { get; set; }

    [Description("Персонал")]
    [DisplayName("Персонал")]
    public EntityRef<PERSONAL> PERSONAL { get; set; }
}