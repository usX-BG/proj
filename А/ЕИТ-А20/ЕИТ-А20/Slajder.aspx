<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Slajder.aspx.cs" Inherits="ЕИТ_А20.Slajder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Slajder</title>
    <link href="stil/main.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
        <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/Slajder.aspx" Text="Slajder" Value="Slajder"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/O_aplikaciji.aspx" Text="O aplikaciji" Value="O aplikaciji"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </form>
    <div id="slike">
        <img class="imgC slideImg" src="img/saobracajm.png" />
        <img class="imgC slideImg" src="img/elektronika.png" />
        <img class="imgC slideImg" src="img/elektrotehnika.png" />
        <img class="imgC slideImg" src="img/masinstom.png" />
        <img class="imgC slideImg" src="img/masinstvo.png" />
        <img class="imgC slideImg" src="img/mesc.png" />
        <img class="imgC slideImg" src="img/saobracaj.png" />
    </div>
    <div id="indikatori">
        <span class="indik"></span>
        <span class="indik"></span>
        <span class="indik"></span>
        <span class="indik"></span>
        <span class="indik"></span>
        <span class="indik"></span>
        <span class="indik"></span>
    </div>
</body>
<script src="skripte/main.js"></script>
</html>
