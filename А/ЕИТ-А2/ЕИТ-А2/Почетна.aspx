<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Почетна.aspx.cs" Inherits="ЕИТ_А2.Почетна" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Фото галерија</title>
    <link href="styles/style.css" rel="stylesheet" />
</head>
<body>
    <div class="header">
        <ul>
            <li><a style="cursor:not-allowed;">Почетна</a></li>
            <li><a href="Упутство.aspx">Упутство</a></li>
            <li><a href="О_Аутору.aspx">О Аутору</a></li>
        </ul>
    </div>
    <div class="container">
        <div class="container-head">
            <strong><p id="head-img-title">Slika</p></strong>
            <img src="img/slika.jpg" id="head-img"/>
        </div>
    <div class="container-img">
        <img src="img/slika1.jpg" id="1" class="img-bottom" onclick="imgClick(this.id)"/>
        <img src="img/slika2.jpg" id="2" class="img-bottom" onclick="imgClick(this.id)"/>
        <img src="img/slika3.jpg" id="3" class="img-bottom" onclick="imgClick(this.id)"/>
        <img src="img/slika4.jpg" id="4" class="img-bottom" onclick="imgClick(this.id)"/>
        <img src="img/slika5.jpg" id="5" class="img-bottom" onclick="imgClick(this.id)"/>
        <img src="img/slika6.jpg" id="6" class="img-bottom" onclick="imgClick(this.id)"/>
        <img src="img/slika7.jpg" id="7" class="img-bottom" onclick="imgClick(this.id)"/>
        <img src="img/slika8.jpg" id="8" class="img-bottom" onclick="imgClick(this.id)"/>
        <img src="img/slika9.jpg" id="9" class="img-bottom" onclick="imgClick(this.id)"/>
        <img src="img/slika10.jpg" id="10" class="img-bottom" onclick="imgClick(this.id)"/>
    </div>
    </div>
</body>
<script src="js/main.js"></script>
</html>
