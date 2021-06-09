<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uputstvo.aspx.cs" Inherits="ЕИТ_А1.Uputstvo" %>

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
        <strong>Potrebno je preci misom preko slike i ona zavristi. <br />
        Ako kliknete na neku sliku istoci vam prozor sa informacijama o istome.</strong>
    </div>
    </form>
</body>
</html>
