using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;

[TableName("Користувачі")]
[DisplayColumn("Name", "Name")]
public class USER_Metadata
{

	[Required(ErrorMessage = "Поле 'Назва медичної установи' не може бути порожнім")]
    [StringLength(250)]
    [Description("Назва медичної установи")]
    [DisplayName("Назва медичної установи")]
    [DefaultValue("<Введіть назву медичної установи>")]
    [RegularExpression("(?!^<Введіть назву медичної установи>$).*", ErrorMessage = "Необхідно ввести назву медичної установи")]
    public string LOGIN { get; set; }

	[Required(ErrorMessage = "Поле 'Назва медичної установи' не може бути порожнім")]
    [StringLength(50)]
    [Description("Назва медичної установи")]
    [DisplayName("Назва медичної установи")]
    [DefaultValue("<Введіть назву медичної установи>")]
    [RegularExpression("(?!^<Введіть назву медичної установи>$).*", ErrorMessage = "Необхідно ввести назву медичної установи")]
    public string PASSWORD { get; set; }

    public string ROLE { get; set; }

    public int PATIENT_ID { get; set; }

    public System.Nullable<System.DateTime> ACTIVATEDDATE { get; set; }

    public System.Nullable<System.DateTime> ADDEDDATE { get; set; }

    public System.Nullable<System.DateTime> LASTVISITDATE { get; set; }

    public EntityRef<PATIENT> PATIENT { get; set; }

}



   