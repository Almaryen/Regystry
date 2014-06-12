using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

/// <summary>
/// Summary description for TEMPLATEGRAFTIME_Metadata
/// </summary>
 [TableName("Шаблон графіку прийому лікаря")]
public class TEMPLATEGRAFTIME_Metadata
{

     [Description("Понеділок з")]
     [DisplayName("Понеділок з")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> MONDAY_FROM { get; set; }
     [Description("Понеділок по")]
     [DisplayName("Понеділок по")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> MONDAY_UNTIL { get; set; }
     [Description("Вівторок з")]
     [DisplayName("Вівторок з")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> TUESDAY_FROM { get; set; }
     [Description("Вівторок по")]
     [DisplayName("Вівторок по")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> TUESDAY_UNTIL { get; set; }
     [Description("Середа з")]
     [DisplayName("Середа з")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> WEDNESDAY_FROM { get; set; }
     [Description("Середа по")]
     [DisplayName("Середа по")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> WEDNESDAY_UNTIL { get; set; }
     [Description("Четвер з")]
     [DisplayName("Четвер з")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> THURSDAY_FROM { get; set; }
     [Description("Четвер по")]
     [DisplayName("Четвер по")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> THURSDAY_UNTIL { get; set; }
     [Description("П'ятниця з")]
     [DisplayName("П'ятниця з")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> FRIDAY_FROM { get; set; }
     [Description("П'ятниця по")]
     [DisplayName("П'ятниця по")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> FRIDAY_UNTIL { get; set; }
     [Description("Субота з")]
     [DisplayName("Субота з")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> SATURDAY_FROM { get; set; }
     [Description("Субота по")]
     [DisplayName("Субота по")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> SATURDAY_UNTIL { get; set; }
     [Description("Неділя з")]
     [DisplayName("Неділя з")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> SUNDAY_FROM { get; set; }
     [Description("Неділя по")]
     [DisplayName("Неділя по")]
     [UIHint("Time")]
     public System.Nullable<System.DateTime> SUNDAY_UNTIL { get; set; }
     [Description("Посада")]
     [DisplayName("Посада")]
     public int POST_ID { get; set; }
     [Description("Назва шаблону")]
     [DisplayName("Назва шаблону")]
     public string MODE { get; set; }
     [Description("Посада")]
     [DisplayName("Посада")]
     public EntityRef<POST> POST { get; set; }
}

