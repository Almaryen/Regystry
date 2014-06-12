using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;
using System.Web.DynamicData;


[TableName("Прийом")]

public class RECEPTION_Metadata
{
    public int ID { get; set; }

    public int PATIENT_ID { get; set; }

    public System.Nullable<System.DateTime> RTIMESTART { get; set; }

    public System.Nullable<System.DateTime> RDATE { get; set; }

    public int POST_ID { get; set; }

    public System.Nullable<System.DateTime> RTIMESTOP { get; set; }

    public EntityRef<PATIENT> PATIENT { get; set; }

    public EntityRef<POST> POST { get; set; }
}