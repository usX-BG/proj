<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Program.aspx.cs" Inherits="ЕИТ_А14.Program" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="styles/main.css" rel="stylesheet" />
    <title>TV program</title>
</head>
<body>
    <div class="nav">
        <ul>
            <li>
                <a href="Program.aspx">Program</a>
            </li>
            <li>
                <a href="Kontakt.aspx">Kontakt</a>
            </li>
            <li>
                <a href="Korisnicko_uputstvo.aspx">Korisnicko uputstvo</a>
            </li>
        </ul>
    </div>
    <form runat="server">
    <div class="forma">
            Datum programa<asp:DropDownList ID="ddlDatum" runat="server" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="ddlDatum_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Tip programa"></asp:Label>
            <asp:DropDownList ID="ddlTip" runat="server" Width="150px">
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnTrazi" runat="server" Text="Trazi" OnClick="btnTrazi_Click" />
    </div>
    </form>
    <div id="container" runat="server">

    </div>
</body>
</html>
