using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;

[TableName("Область")]

public class REGION_Metadata
{
    [Required(ErrorMessage = "Поле 'Область' не може бути порожнім")]
    [StringLength(250)]
    [Description("Область")]
    [DisplayName("Область")]
    [DefaultValue("<Введіть назву області>")]
    [RegularExpression("(?!^<Введіть назву області>$).*", ErrorMessage = "Необхідно ввести назву області")]
    public string REG_NAME { get; set; }

    [Description("Район")]
    [DisplayName("Район")]
    public EntitySet<DISTRICT> DISTRICTs { get; set; }
    [Description("Пацієнт")]
    [DisplayName("Пацієнт")]
    public EntitySet<PATIENT> PATIENTs { get; set; }
}




