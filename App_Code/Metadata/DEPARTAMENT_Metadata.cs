using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;

[TableName("Відділення")]
public class DEPARTAMENT_Metadata
{
    [Required(ErrorMessage = "Поле 'Назва відділення' не може бути порожнім")]
    [StringLength(20)]
    [Description("Назва відділення")]
    [DisplayName("Назва відділення")]
    [DefaultValue("<Введіть назву відділення>")]
    [RegularExpression("(?!^<Введіть назву відділення>$).*", ErrorMessage = "Необхідно ввести назву відділення")]
    private string DEPART_NAME { get; set; }

    
    [Description("Кабінети")]
    [DisplayName("Кабінети")]
    public EntitySet<OFFICE> OFFICEs { get; set; }
    
    [ScaffoldColumn(false)]
    public EntitySet<POST> POSTs { get; set; }
    
    [Description("Медичні установи")]
    [DisplayName("Медичні установи")]
    public EntityRef<MEDORGANIZATION> MEDORGANIZATION { get; set; }

}


