<%@  Page Language="C#" MasterPageFile="Main.Master" AutoEventWireup="true" CodeFile="ViewMedorgaspx.aspx.cs" Inherits="ViewMedorgaspx"  %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
    <asp:Label ID="Label1" runat="server" Text="Виберіть медичну установу"></asp:Label>   
    <asp:DropDownList ID="MedorgDDL" runat="server" DataSourceID="SqlDataSource1" 
            DataTextField="MEDORG_NAME" DataValueField="MEDORG_ID" Height="29px" 
            Width="188px" AutoPostBack="True" 
        onselectedindexchanged="MedorgDDL_SelectedIndexChanged">
        
   
        <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:HospitalConnectionString %>" 
            SelectCommand="SELECT * FROM [MEDORGANIZATION]"></asp:SqlDataSource>

<asp:Label ID="Label2" runat="server" Text="Виберіть відділення"></asp:Label>   
   
<asp:DropDownList ID="DepartDDL" runat="server" 
            DataSourceID="SqlDataSource2" DataTextField="DEPART_NAME" 
            DataValueField="DEPART_ID" Height="29px" Width="188px" 
        AutoPostBack="True">
        </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:HospitalConnectionString %>" 
            SelectCommand="SELECT [DEPART_ID], [DEPART_NAME] FROM [DEPARTAMENT] WHERE ([MEDORG_ID] = @MEDORG_ID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="MedorgDDL" Name="MEDORG_ID" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        
        
        
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
            ConnectionString="<%$ ConnectionStrings:HospitalConnectionString %>" 
            SelectCommand="ViewPersonal" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="DepartDDL" Name="DepartId" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
    </asp:SqlDataSource>
<br /><br />
<asp:Label ID="Label3" runat="server" Text="Виберіть лікаря"></asp:Label>   
   
        <asp:GridView ID="grid" runat="server" AutoGenerateColumns="False" 
        AllowPaging="True" AllowSorting="True" CssClass="gridview"
            DataSourceID="SqlDataSource3" 
        onselectedindexchanged="grid_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="MEDPROF_NAME" HeaderText="Професія" 
                    SortExpression="MEDPROF_NAME" />
                <asp:BoundField DataField="LASTNAME" HeaderText="Прізвище" 
                    SortExpression="LASTNAME" />
                <asp:BoundField DataField="FIRSTNAME" HeaderText="Ім'я" 
                    SortExpression="FIRSTNAME" />
                <asp:BoundField DataField="MIDLNAME" HeaderText="По батькові" 
                    SortExpression="MIDLNAME" />
            </Columns>
            
  
                   <EmptyDataTemplate>
                     Не має лікарів, що ведуть прийом
                </EmptyDataTemplate>
        </asp:GridView>
</asp:Content>
