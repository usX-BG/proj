<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pocetna.aspx.cs" Inherits="ЕИТ_А1.Pocetna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Menu ID="Menu1" runat="server" BackColor="#00FF99" BorderColor="#009933" BorderStyle="Solid" BorderWidth="2px" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Pocetna.aspx" Text="Pocetna" Value="Pocetna"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Uputstvo.aspx" Text="Uputstvo" Value="Uputstvo"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/O_Autoru.aspx" Text="O autoru" Value="O autoru"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#CC00CC" />
        </asp:Menu>
        <br />

        <img class="prva" src="img/svinja.jpg" />
        <img class="druga" src="img/macka.jpg" />
        <img class="treca" src="img/ker.jpg" />
        <img class="cetvrta" src="img/konj.jpg" />
        <img class="peta" src="img/patka.jpg" />
    </div>
<script src="script.js"></script>
    </form>
</body>
    
</html>
