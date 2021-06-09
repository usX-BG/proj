<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kontakt.aspx.cs" Inherits="ЕИТ_А7.Kontakt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Red_voznje.aspx" Text="Red voznje" Value="Red voznje"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Kontakt.aspx" Text="Kontakt" Value="Kontakt"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Korisnicko_uputstvo.aspx" Text="Korisnicko uputstvo" Value="Korisnicko uputstvo"></asp:MenuItem>
            </Items>
        </asp:Menu>
    <div>
    
        Ime:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Email:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        Naslov:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Poruka:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Posalji" />
    
    </div>
    </form>
</body>
</html>
