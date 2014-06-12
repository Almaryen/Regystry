using System.Web.DynamicData;
using System.Web.UI;

public partial class DynamicData_FieldTemplates_RichDateTime : FieldTemplateUserControl
{
    public override Control DataControl
    {
        get { return dateTime; }
    }
}
