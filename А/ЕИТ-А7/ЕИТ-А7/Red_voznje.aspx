<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Red_voznje.aspx.cs" Inherits="ЕИТ_А7.Red_voznje" %>

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
        Autobuska linija:<asp:DropDownList ID="DropDownList1" runat="server" Width="178px" AutoPostBack="True" OnTextChanged="indexChng">
        </asp:DropDownList>
        <br />
        Smer:
        <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="161px" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Trazi" />
    </form>
    <div id="tabela" runat="server">

    </div>
</body>
</html>
