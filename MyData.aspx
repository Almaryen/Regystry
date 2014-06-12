<%@ Page Language="C#" MasterPageFile="Main.Master" AutoEventWireup="true" CodeFile="MyData.aspx.cs" Inherits="MyData" %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
     <asp:Label ID="Label2" runat="server" Text="Прізвище"></asp:Label>
    <asp:TextBox ID="PatLastName" runat="server"></asp:TextBox>

    <asp:Label ID="Label1" runat="server" Text="Ім'я"></asp:Label>
    <asp:TextBox ID="PatFirstName" runat="server"></asp:TextBox>
    
   
    
    <asp:Label ID="Label3" runat="server" Text="По батькові"></asp:Label>
    <asp:TextBox ID="PatMidlName" runat="server"></asp:TextBox>

    <asp:Label ID="Label4" runat="server" Text="Дата народження"></asp:Label>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

    <asp:Label ID="Label5" runat="server" Text="Стать"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="0">Жіноча</asp:ListItem>
        <asp:ListItem Value="1">Чоловіча</asp:ListItem>
        
    </asp:DropDownList>
</asp:Content>