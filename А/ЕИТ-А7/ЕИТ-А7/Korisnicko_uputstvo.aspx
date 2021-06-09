<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Korisnicko_uputstvo.aspx.cs" Inherits="ЕИТ_А7.Korisnicko_uputstvo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Red_voznje.aspx" Text="Red voznje" Value="Red voznje"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Kontakt.aspx" Text="Kontakt" Value="Kontakt"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Korisnicko_uputstvo.aspx" Text="Korisnicko uputstvo" Value="Korisnicko uputstvo"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <p>Ova aplikacija se koristi tako sto se oznace polja za pretragu i pritisne dugme trazi.</p>
    </div>
    </form>
</body>
</html>
