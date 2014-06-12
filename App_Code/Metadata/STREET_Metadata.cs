using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;


[TableName("Вулиці")]
public class STREET_Metadata
{
    [Required(ErrorMessage = "Поле 'Вулиці' не може бути порожнім")]
    [StringLength(50)]
    [Description("Вулиці")]
    [DisplayName("Вулиці")]
    [DefaultValue("<Введіть назву вулиці>")]
    [RegularExpression("(?!^<Введіть назву вулиці>$).*", ErrorMessage = "Необхідно ввести назву вулиці")]
    public string STREET_NAME { get; set; }

    [Description("Населеннійпункт")]
    [DisplayName("Населеннійпункт")]
    public int SETTL_ID { get; set; }


     [ScaffoldColumn(false)]
    public EntitySet<DISTRICT_STREET> DISTRICT_STREETs { get; set; }

    [Description("Населеннійпункт")]
    [DisplayName("Населеннійпункт")]
    public EntityRef<SETTLEMENT> SETTLEMENT { get; set; }
}