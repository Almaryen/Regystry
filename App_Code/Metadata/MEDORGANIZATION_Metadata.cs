using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;

[TableName("Медичні Установи")]
public class MEDORGANIZATION_Metadata
{
    [Required(ErrorMessage = "Поле 'Назва медичної установи' не може бути порожнім")]
    [StringLength(250)]
    [Description("Назва медичної установи")]
    [DisplayName("Назва медичної установи")]
    [DefaultValue("<Введіть назву медичної установи>")]
    [RegularExpression("(?!^<Введіть назву медичної установи>$).*", ErrorMessage = "Необхідно ввести назву медичної установи")]
	public string MEDORG_NAME{ get; set; }

    //[ScaffoldColumn(false)]
    [Description("Відділення")]
    [DisplayName("Відділення")]
    public EntitySet<DEPARTAMENT> DEPARTAMENTs { get; set; }
}







    


    
