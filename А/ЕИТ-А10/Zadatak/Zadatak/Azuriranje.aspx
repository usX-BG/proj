<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Azuriranje.aspx.cs" Inherits="Zadatak.Azuriranje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/main.css" rel="stylesheet" />
</head>
<body>
    <div class="nav">
    <ul>
        <li><a href="Pregled.aspx">Pregled</a></li>
        <li><a href="Azuriranje.aspx">Azuriranje</a></li>
    </ul>
    </div>
    <form id="form1" runat="server">
    <div id="container" runat="server"></div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" Height="36px" Width="211px">
        </asp:DropDownList>
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
