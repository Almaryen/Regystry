using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;


[TableName("Район")]
public class DISTRICT_Metadata
{
    [Required(ErrorMessage = "Поле 'Район' не може бути порожнім")]
    [StringLength(250)]
    [Description("Район")]
    [DisplayName("Район")]
    [DefaultValue("<Введіть назву району>")]
    [RegularExpression("(?!^<Введіть назву району>$).*", ErrorMessage = "Необхідно ввести назву району")]
    
    public string DISTR_NAME { get; set; }

    [Description("Область")]
    [DisplayName("Область")]
    public int REG_ID { get; set; }
    
    [ScaffoldColumn(false)]
    public EntitySet<PATIENT> PATIENTs { get; set; }
    
    //[ScaffoldColumn(false)]
    [Description("Населенний пункт")]
    [DisplayName("Населенний пункт")]
    public EntitySet<SETTLEMENT> SETTLEMENTs { get; set; }

    [Description("Область")]
    [DisplayName("Область")]
    public EntityRef<REGION> REGION { get; set; }
}






