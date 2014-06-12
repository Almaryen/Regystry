// Type: System.Web.UI.Control
// Assembly: System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Web.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Runtime;
using System.Security.Permissions;
using System.Web;
using System.Web.Routing;
using System.Web.UI.Adapters;

namespace System.Web.UI
{
    [DesignerSerializer("Microsoft.VisualStudio.Web.WebForms.ControlCodeDomSerializer, Microsoft.VisualStudio.Web, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [ToolboxItem("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [Themeable(false)]
    [ToolboxItemFilter("System.Web.UI", ToolboxItemFilterType.Require)]
    [Bindable(true)]
    [DefaultProperty("ID")]
    [DesignerCategory("Code")]
    [Designer("System.Web.UI.Design.ControlDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class Control : IComponent, IDisposable, IParserAccessor, IUrlResolutionService, IDataBindingsAccessor, IControlBuilderAccessor, IControlDesignerAccessor, IExpressionsAccessor
    {
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        public Control();

        protected virtual ControlAdapter ResolveAdapter();

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        protected bool HasEvents();

        public string GetRouteUrl(object routeParameters);
        public string GetRouteUrl(string routeName, object routeParameters);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public string GetRouteUrl(RouteValueDictionary routeParameters);

        public string GetRouteUrl(string routeName, RouteValueDictionary routeParameters);
        public string GetUniqueIDRelativeTo(Control control);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public virtual void ApplyStyleSheetSkin(Page page);

        protected virtual void OnDataBinding(EventArgs e);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public virtual void DataBind();

        protected virtual void DataBind(bool raiseOnDataBinding);
        protected virtual void DataBindChildren();

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        protected virtual void AddParsedSubObject(object obj);

        protected void EnsureID();
        protected internal virtual void OnInit(EventArgs e);
        protected void ClearChildState();
        protected void ClearChildControlState();
        protected void ClearChildViewState();
        protected void ClearEffectiveClientIDMode();
        protected void ClearCachedClientID();
        public virtual void Focus();
        protected internal virtual void LoadControlState(object savedState);
        protected virtual void LoadViewState(object savedState);
        protected internal string MapPathSecure(string virtualPath);
        protected internal Stream OpenFile(string path);
        protected internal virtual void OnLoad(EventArgs e);
        protected internal virtual void OnPreRender(EventArgs e);
        protected void BuildProfileTree(string parentId, bool calcViewState);
        protected internal virtual object SaveControlState();
        protected virtual object SaveViewState();

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        protected internal virtual void Render(HtmlTextWriter writer);

        protected internal virtual void RenderChildren(HtmlTextWriter writer);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        public virtual void RenderControl(HtmlTextWriter writer);

        protected void RenderControl(HtmlTextWriter writer, ControlAdapter adapter);
        protected internal virtual void OnUnload(EventArgs e);
        public virtual void Dispose();
        protected void RaiseBubbleEvent(object source, EventArgs args);
        protected virtual bool OnBubbleEvent(object source, EventArgs args);
        protected internal virtual void AddedControl(Control control, int index);
        protected virtual ControlCollection CreateControlCollection();

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        protected internal virtual void CreateChildControls();

        public string ResolveUrl(string relativeUrl);
        public string ResolveClientUrl(string relativeUrl);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public virtual Control FindControl(string id);

        protected virtual Control FindControl(string id, int pathOffset);

        [SecurityPermission(SecurityAction.Demand, Unrestricted = true)]
        protected virtual IDictionary GetDesignModeState();

        public virtual bool HasControls();
        protected bool IsLiteralContent();

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        protected virtual void TrackViewState();

        protected virtual void EnsureChildControls();
        protected internal virtual void RemovedControl(Control control);
        protected virtual void SetDesignModeState(IDictionary data);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void SetRenderMethodDelegate(RenderMethod renderMethod);

        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        void IParserAccessor.AddParsedSubObject(object obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected void BeginRenderTracing(TextWriter writer, object traceObject);

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected void EndRenderTracing(TextWriter writer, object traceObject);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public void SetTraceData(object traceDataKey, object traceDataValue);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SetTraceData(object tracedObject, object traceDataKey, object traceDataValue);

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        IDictionary IControlDesignerAccessor.GetDesignModeState();

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        void IControlDesignerAccessor.SetDesignModeState(IDictionary data);

        void IControlDesignerAccessor.SetOwnerControl(Control owner);

        [WebSysDescription("Control_ClientIDMode")]
        [DefaultValue(ClientIDMode.Inherit)]
        [Themeable(false)]
        [WebCategory("Behavior")]
        public virtual ClientIDMode ClientIDMode { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; set; }

        [WebSysDescription("Control_ClientID")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string ClientID { get; }

        protected char ClientIDSeparator { get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        protected internal virtual HttpContext Context { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; }

        protected ControlAdapter Adapter { get; }
        protected internal bool DesignMode { get; }

        protected EventHandlerList Events { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; }

        [Themeable(false)]
        [WebSysDescription("Control_ID")]
        [ParenthesizePropertyName(true)]
        [MergableProperty(false)]
        [Filterable(false)]
        public virtual string ID { get; set; }

        [WebSysDescription("Control_EnableTheming")]
        [Browsable(false)]
        [DefaultValue(true)]
        [Themeable(false)]
        [WebCategory("Behavior")]
        public virtual bool EnableTheming { get; set; }

        protected internal bool IsChildControlStateCleared { get; }

        [DefaultValue("")]
        [WebSysDescription("Control_SkinId")]
        [Browsable(false)]
        [Filterable(false)]
        [WebCategory("Behavior")]
        public virtual string SkinID { get; set; }

        [Themeable(false)]
        [WebSysDescription("Control_MaintainState")]
        [WebCategory("Behavior")]
        [DefaultValue(true)]
        public virtual bool EnableViewState { get; [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        set; }

        [DefaultValue(ViewStateMode.Inherit)]
        [Themeable(false)]
        [WebCategory("Behavior")]
        [WebSysDescription("Control_ViewStateMode")]
        public virtual ViewStateMode ViewStateMode { get; set; }

        protected internal bool IsViewStateEnabled { get; }

        [WebSysDescription("Control_NamingContainer")]
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual Control NamingContainer { get; }

        [Bindable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public Control BindingContainer { get; }

        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Control DataItemContainer { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Bindable(false)]
        public Control DataKeysContainer { get; }

        protected char IdSeparator { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; }

        protected bool LoadViewStateByID { get; }

        [Browsable(false)]
        [Bindable(false)]
        [WebSysDescription("Control_Page")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual Page Page { get; set; }

        [Browsable(false)]
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual Version RenderingCompatibility { get; set; }

        [WebSysDescription("Control_TemplateControl")]
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TemplateControl TemplateControl { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        get; [EditorBrowsable(EditorBrowsableState.Never)]
        set; }

        [WebSysDescription("Control_Parent")]
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual Control Parent { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; }

        [WebSysDescription("Control_TemplateSourceDirectory")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string TemplateSourceDirectory { get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [WebSysDescription("Control_TemplateSourceDirectory")]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public string AppRelativeTemplateSourceDirectory { get; [EditorBrowsable(EditorBrowsableState.Never)]
        set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [WebSysDescription("Control_Site")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ISite Site { get; set; }

        [DefaultValue(true)]
        [Bindable(true)]
        [WebCategory("Behavior")]
        [WebSysDescription("Control_Visible")]
        public virtual bool Visible { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [WebSysDescription("Control_UniqueID")]
        public virtual string UniqueID { get; }

        protected bool HasChildViewState { get; }

        [WebSysDescription("Control_Controls")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual ControlCollection Controls { get; }

        [WebCategory("Behavior")]
        [DefaultValue(ValidateRequestMode.Inherit)]
        [WebSysDescription("Control_ValidateRequestMode")]
        public virtual ValidateRequestMode ValidateRequestMode { get; [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [WebSysDescription("Control_State")]
        protected virtual StateBag ViewState { get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        protected virtual bool ViewStateIgnoresCase { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; }

        protected bool ChildControlsCreated { get; set; }
        protected bool IsTrackingViewState { get; }
        bool IDataBindingsAccessor.HasDataBindings { get; }
        DataBindingCollection IDataBindingsAccessor.DataBindings { get; }
        IDictionary IControlDesignerAccessor.UserData { get; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        ControlBuilder IControlBuilderAccessor.ControlBuilder { get; }

        bool IExpressionsAccessor.HasExpressions { get; }
        ExpressionBindingCollection IExpressionsAccessor.Expressions { get; }

        [WebSysDescription("Control_OnDisposed")]
        public event EventHandler Disposed;

        [WebSysDescription("Control_OnDataBind")]
        [WebCategory("Data")]
        public event EventHandler DataBinding;

        [WebSysDescription("Control_OnInit")]
        public event EventHandler Init;

        [WebSysDescription("Control_OnLoad")]
        public event EventHandler Load;

        [WebSysDescription("Control_OnPreRender")]
        public event EventHandler PreRender;

        [WebSysDescription("Control_OnUnload")]
        public event EventHandler Unload;
    }
}
