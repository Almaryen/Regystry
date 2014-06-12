using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;


[TableName("Персонал")]
public class PERSONAL_Metadata
{
    [Required(ErrorMessage = "Поле 'Ім'я' не може бути порожнім")]
    [StringLength(50)]
    [Description("Ім'я")]
    [DisplayName("Ім'я")]
    [DefaultValue("<Введіть ім'я>")]
    [RegularExpression("(?!^<Введіть ім'я>$).*", ErrorMessage = "ім'я")]
    public string FIRSTNAME{ get; set; }

    [Required(ErrorMessage = "Поле 'По батькові' не може бути порожнім")]
    [StringLength(50)]
    [Description("По батькові")]
    [DisplayName("По батькові")]
    [DefaultValue("<Введіть по батькові>")]
    [RegularExpression("(?!^<Введіть по батькові>$).*", ErrorMessage = "по батькові")]
    public string MIDLNAME{ get; set; }

    [Required(ErrorMessage = "Поле 'Прізвище' не може бути порожнім")]
    [StringLength(50)]
    [Description("Прізвище")]
    [DisplayName("Прізвище")]
    [DefaultValue("<Введіть прізвище>")]
    [RegularExpression("(?!^<Введіть прізвище>$).*", ErrorMessage = "прізвище")]
    public string LASTNAME{ get; set; }

    [Description("Посада")]
    [DisplayName("Посада")]
    public EntitySet<POST> POSTs{ get; set; }
	
}

