using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;

[TableName("Населенні пункти")]
public class SETTLEMENT_Metadata
{
[Required(ErrorMessage = "Поле 'Назва населенного пункту' не може бути порожнім")]
    [StringLength(250)]
    [Description("Назва населенного пункту")]
    [DisplayName("Назва населенного пункту")]
    [DefaultValue("<Введіть назву населенного пункту>")]
    [RegularExpression("(?!^<Введіть назву населенного пункту>$).*", ErrorMessage = "Необхідно ввести назву населенного пункту")]

    public string SETTL_NAME { get; set; }

    [Description("Назва населенного пункту")]
    [DisplayName("Назва населенного пункту")]
    public int DISTR_ID { get; set; }

     [ScaffoldColumn(false)]
    public EntitySet<PATIENT> PATIENTs { get; set; }

    [Description("Вулиці")]
    [DisplayName("Вулиці")]
    public EntitySet<STREET> STREETs { get; set; }

    [Description("Райони")]
    [DisplayName("Райони")]
    public EntityRef<DISTRICT> DISTRICT { get; set; }	
    
 
}









    


    
