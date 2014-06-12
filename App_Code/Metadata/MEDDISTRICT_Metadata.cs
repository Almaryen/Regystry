using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;

[TableName("Медичні дільниці")]
public class MEDDISTRICT_Metadata
{
    [Description("Вікові категорії дільниць")]
    [DisplayName("Вікові категорії дільниць")]
    public string AGECATEGORY { get; set; }

    [Description("Посади лікарів")]
    [DisplayName("Посади лікарів")]
    public int POST_ID { get; set; }

    [Required(ErrorMessage = "Поле 'Назва дільниці' не може бути порожнім")]
    [StringLength(250)]
    [Description("Назва дільниці")]
    [DisplayName("Назва дільниці")]
    [DefaultValue("<Введіть назву дільниці>")]
    [RegularExpression("(?!^<Введіть назву дільниці>$).*", ErrorMessage = "Необхідно ввести назву дільниці")]
    public string MEDDISTRICT_NAME { get; set; }

    [Description("Вікові категорії дільниць")]
    [DisplayName("Вікові категорії дільниць")]
    public EntitySet<MEDDISTRICT_AGECATEGORY> MEDDISTRICT_AGECATEGORies { get; set; }

    [ScaffoldColumn(false)]
    public EntitySet<PATIENT> PATIENTs { get; set; }

    [Description("Посади лікарів")]
    [DisplayName("Посади лікарів")]
    public EntityRef<POST> POST { get; set; }


}







