<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="O_Autoru.aspx.cs" Inherits="ЕИТ_А1.O_Autoru" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    
    
        <asp:Menu ID="Menu1" runat="server" BackColor="#00FF99" BorderColor="#009933" BorderStyle="Solid" BorderWidth="2px" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Pocetna.aspx" Text="Pocetna" Value="Pocetna"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Uputstvo.aspx" Text="Uputstvo" Value="Uputstvo"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/O_Autoru.aspx" Text="O autoru" Value="O autoru"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#CC00CC" />
        </asp:Menu>
    <div class="str">
        <strong>Ja se zovem Martin Muharemovic. <br />Idem u srednju tehnicku skolu Ivan Saric.</strong>
    </div>
    </form>
</body>
</html>
