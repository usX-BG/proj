<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Korisnicko_uputstvo.aspx.cs" Inherits="ЕИТ_А8.Korisnicko_uputstvo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="stil/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
        <Items>
            <asp:MenuItem NavigateUrl="~/Veb_Prodavnica.aspx" Text="Veb prodavnica" Value="Veb prodavnica"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Korisnicko_uputstvo.aspx" Text="Korisnicko uputstvo" Value="Korisnicko uputstvo"></asp:MenuItem>
        </Items>
    </asp:Menu>
        Unesite sve parametre za pretragu i pogledajte nas asortiman.
    </div>
    </form>
</body>
</html>
