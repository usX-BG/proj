<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="drzava.aspx.cs" Inherits="ЕИТ_А4.drzava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" onload="UpisiDrzavu()">
<head runat="server">
    <title></title>
</head>
<body>
    Назив државе:<p id="naziv"></p><br />
    Главни град:<p id="gl-grad"></p><br />
    Површина:<p id="povrsina"></p><br />
</body>
<script src="js/main.js" type="text/javascript">
    
</script>
    <script type="text/javascript">
        UpisiDrzavu();
    </script>
</html>
