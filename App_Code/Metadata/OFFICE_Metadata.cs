using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;

[TableName("Кабінети")]
public class OFFICE_Metadata
{

    [Required(ErrorMessage = "Поле 'Номер кабінету (назва)' не може бути порожнім")]
    [StringLength(20)]
    [Description("Номер кабінету (назва)")]
    [DisplayName("Номер кабінету (назва)")]
    [DefaultValue("<Введіть номер кабінету (назву)>")]
    [RegularExpression("(?!^<Введіть номер кабінету (назву)>$).*", ErrorMessage = "номер кабінету (назву)")]
     public string NUMBER { get; set; }

    [Description("Відділення")]
    [DisplayName("Відділення")]
    public int DEPART_ID { get; set; }

    [Description("Графік прийому")]
    [DisplayName("Графік прийому")]
    public EntitySet<SCHEDULE_DOC> SCHEDULE_DOCs { get; set; }
    [Description("Відділення")]
    [DisplayName("Відділення")]
    public EntityRef<DEPARTAMENT> DEPARTAMENT { get; set; }
}



