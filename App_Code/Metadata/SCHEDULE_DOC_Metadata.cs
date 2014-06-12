using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;


[TableName("Графік прийому")]
public class SCHEDULE_DOC_Metadata
{
    [Description("Початок прийому")]
    [DisplayName("Початок прийому")]
    [DisplayFormat(DataFormatString = "{0:mm-dd-yyyy}")]
    [UIHint("RichDateTime")]
	public System.Nullable<System.DateTime> STARTTIME{ get; set; }
	
    [Description("Кінець прийому")]
    [DisplayName("Кінець прийому")]
    [DisplayFormat(DataFormatString = "{0:mm-dd-yyyy}")]
    [UIHint("RichDateTime")]
	public System.Nullable<System.DateTime> ENDTIME{ get; set; }
	

	[Description("Тип прийому")]
    [DisplayName("Тип прийому")]
	public System.Nullable<int> MODE{ get; set; }
	
    [Description("Посада")]
    [DisplayName("Посада")]
	public int POST_ID{ get; set; }

	[Description("Кабінет")]
    [DisplayName("Кабінет")]
    public int OFFICES_ID { get; set; }

	[Description("Посади")]
    [DisplayName("Посади")]
	public EntityRef<POST> POST{ get; set; }

	[Description("Кабінети")]
    [DisplayName("Кабінети")]
	public EntityRef<OFFICE> OFFICE{ get; set; }
}

