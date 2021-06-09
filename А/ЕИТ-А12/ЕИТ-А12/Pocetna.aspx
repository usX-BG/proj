<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pocetna.aspx.cs" Inherits="ЕИТ_А12.Pocetna" %>

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
        Ime:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="imeErr" runat="server" ControlToValidate="TextBox1" ErrorMessage="Niste uneli ime" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        Email:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="mejlErr" runat="server" ControlToValidate="TextBox2" ErrorMessage="Mejl adresa nije u ispravnom formatu." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Niste uneli email" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        Komentar:<asp:TextBox ID="TextBox3" runat="server" Rows="4" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Niste uneli svoj komentar" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Dodaj komentar" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
