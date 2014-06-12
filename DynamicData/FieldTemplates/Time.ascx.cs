using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DynamicData_FieldTemplates_Time : FieldTemplateUserControl
{
    public override Control DataControl
    {
        get { return dateTime; }
    }
}

//using System.Web.DynamicData;
//using System.Web.UI;

//public partial class DynamicData_FieldTemplates_RichDateTime : FieldTemplateUserControl
//{
//    public override Control DataControl
//    {
//        get { return dateTime; }
//    }
//}
