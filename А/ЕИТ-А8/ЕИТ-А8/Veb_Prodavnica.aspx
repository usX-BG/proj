<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Veb_Prodavnica.aspx.cs" Inherits="ЕИТ_А8.Veb_Prodavnica" %>

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
        Proizvodjac:<asp:DropDownList ID="ddlProizvodjac" runat="server"></asp:DropDownList>
        <br />
        RAM memorija:<asp:DropDownList ID="ddlRAM" runat="server">
            <asp:ListItem>512MB</asp:ListItem>
            <asp:ListItem>1GB</asp:ListItem>
            <asp:ListItem>1.5GB</asp:ListItem>
            <asp:ListItem>2GB</asp:ListItem>
            <asp:ListItem>3GB</asp:ListItem>
        </asp:DropDownList>
        <br />
        Procesor:<asp:DropDownList ID="ddlProcesor" runat="server">
        </asp:DropDownList>
        <br />
        Kamera:<asp:DropDownList ID="ddlKamera" runat="server">
        </asp:DropDownList>
        <br />
        Ekran:<asp:DropDownList ID="ddlEkran" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnTrazi" runat="server" Text="Trazi" OnClick="btnTrazi_Click" />
    </div>
    </form>
    <div id="tabela" runat="server"></div>
</body>
</html>
