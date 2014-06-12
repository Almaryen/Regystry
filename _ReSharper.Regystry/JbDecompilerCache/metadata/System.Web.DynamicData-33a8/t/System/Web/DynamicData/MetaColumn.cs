// Type: System.Web.DynamicData.MetaColumn
// Assembly: System.Web.DynamicData, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Web.DynamicData.dll

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime;
using System.Web.DynamicData.ModelProviders;

namespace System.Web.DynamicData
{
    public class MetaColumn : IFieldFormattingOptions, IMetaColumn
    {
        public MetaColumn(MetaTable table, ColumnProvider columnProvider);
        protected virtual AttributeCollection BuildAttributeCollection();
        protected internal virtual void Initialize();
        public void ResetMetadata();
        public override string ToString();
        public AttributeCollection Attributes { get; }
        public Type ColumnType { get; }
        public DataTypeAttribute DataTypeAttribute { get; }
        public object DefaultValue { get; }
        public virtual string Description { get; }
        public virtual string DisplayName { get; }
        public PropertyInfo EntityTypeProperty { get; }
        public string FilterUIHint { get; }
        public bool IsBinaryData { get; }
        public bool IsCustomProperty { get; }
        public bool IsFloatingPoint { get; }
        public bool IsForeignKeyComponent { get; }
        public bool IsGenerated { get; }
        public bool IsInteger { get; }
        public bool IsLongString { get; }
        public bool IsPrimaryKey { get; }
        public virtual bool IsReadOnly { get; }
        public bool AllowInitialValue { get; }
        public bool IsRequired { get; }
        public bool IsString { get; }
        public int MaxLength { get; }
        public MetaModel Model { get; }
        public string Name { get; }
        public virtual string Prompt { get; }

        public ColumnProvider Provider { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public string RequiredErrorMessage { get; }
        public virtual bool Scaffold { get; set; }
        public virtual string ShortDisplayName { get; }

        public string SortExpression { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public MetaTable Table { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        public TypeCode TypeCode { get; }
        public virtual string UIHint { get; }
        public bool ApplyFormatInEditMode { get; }
        public bool ConvertEmptyStringToNull { get; }
        public string DataFormatString { get; }
        public bool HtmlEncode { get; }
        public string NullDisplayText { get; }

        string IMetaColumn.Description { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        string IMetaColumn.DisplayName { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        string IMetaColumn.Prompt { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        string IMetaColumn.ShortDisplayName { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }

        IMetaTable IMetaColumn.Table { get; }

        IMetaModel IMetaColumn.Model { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; }
    }
}
