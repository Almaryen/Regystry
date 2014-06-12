using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;


public partial class DynamicData_FieldTemplates_Time_Edit : FieldTemplateUserControl
{



    protected override void ExtractValues(IOrderedDictionary dictionary)
    {
        //string time = hour.SelectedValue.ToString()+Min.SelectedValue.ToString()
        dictionary[Column.Name] = ConvertEditedValue(hour.SelectedValue.ToString() + Min.SelectedValue.ToString());
    }

    public override Control DataControl
    {

        get
        {
            return hour;
          //  return Min;
        }
    }
}


