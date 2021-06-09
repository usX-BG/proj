<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="O_autoru.aspx.cs" Inherits="ЕИТ_А12.O_autoru" %>

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
                <asp:MenuItem NavigateUrl="~/Pocetna.aspx" Text="Pocetna" Value="Pocetna"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Uputstvo.aspx" Text="Uputstvo" Value="Uputstvo"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/O_autoru.aspx" Text="O autoru" Value="O autoru"></asp:MenuItem>
            </Items>
        </asp:Menu>
        Autor ovog projekta je Martin Muharemovic iz Subotice i ima 18 godina.
    </div>
    </form>
</body>
</html>
