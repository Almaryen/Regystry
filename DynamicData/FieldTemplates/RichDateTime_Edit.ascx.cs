using System.Web.DynamicData;
using System.Web.UI;

public partial class DynamicData_FieldTemplates_RichDateTime_Edit : FieldTemplateUserControl
{
    protected override void ExtractValues(System.Collections.Specialized.IOrderedDictionary dictionary)
    {
        dictionary[Column.Name] = ConvertEditedValue(calendar.SelectedDate.ToString());
    }

    public override Control DataControl
    {
        get
        {
            return calendar;
        }
    }
}
