using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;

[TableName("Медичні професії")]
public class MED_PROFESSION_Metadata
{

    [Required(ErrorMessage = "Поле 'Назва медичної професії' не може бути порожнім")]
    [StringLength(250)]
    [Description("Назва медичної професії")]
    [DisplayName("Назва медичної професії")]
    [DefaultValue("<Введіть назву медичної професії>")]
    [RegularExpression("(?!^<Введіть назву медичної професії>$).*", ErrorMessage = "Необхідно ввести назву медичної професії")]
    public string MEDPROF_NAME{ get; set; }

    [Description("Посади")]
    [DisplayName("Посади")]
    public EntitySet<POST> POSTs { get; set; }
}










    


    
