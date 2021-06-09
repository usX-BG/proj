<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="O_aplikaciji.aspx.cs" Inherits="ЕИТ_А20.O_aplikaciji" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>O aplikaciji</title>
    <link href="stil/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/Slajder.aspx" Text="Slajder" Value="Slajder"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/O_aplikaciji.aspx" Text="O aplikaciji" Value="O aplikaciji"></asp:MenuItem>
            </Items>
        </asp:Menu>
    <div>
    <ul>
        <li>
            Napravio: Martin Muharemovic
        </li>
        <li>
            Email: martin@muharemovic.com
        </li>
        <li>
            Aplikacija: Slajder slika
        </li>
        <li>
            Kreirano: 27.04.2021.
        </li>
    </ul>
    </div>
    </form>
</body>
</html>
