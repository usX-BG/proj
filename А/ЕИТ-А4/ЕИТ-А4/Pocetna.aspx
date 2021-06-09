<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pocetna.aspx.cs" Inherits="ЕИТ_А4.Pocetna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Србија и њени суседи</title>
    <link href="styles/style.css" rel="stylesheet" />
</head>
<body>
    <div class="header">
        <ul>
            <li><a style="cursor:not-allowed;">Почетна</a></li>
            <li><a href="Uputstvo.aspx">Упутство</a></li>
            <li><a href="O_autoru.aspx">О аутору</a></li>
        </ul>
    </div>
    <div class="state" id="madjarska">
        <div class="flag" id="madjarskaH" onmouseover="Himna(this.id)">
            <img src="img/madj.jpg" />
        </div>
        <div class="state-name" id="madjarskaID" onclick="Drzava(this.id)">
            Мађарска
        </div>
    </div>
    <div class="state" id="rumunija">
        <div class="flag" id="rumunijaH" onmouseover="Himna(this.id)">
            <img src="img/rum.jpg" />
        </div>
        <div class="state-name" id="rumunijaID" onclick="Drzava(this.id)">
            Румунија
        </div>
    </div>
    <div class="state" id="hrvatska" >
        <div class="flag" id="hrvatskaH" onmouseover="Himna(this.id)">
            <img src="img/hr.png" />
        </div>
        <div class="state-name" id="hrvatskaID" onclick="Drzava(this.id)">
            Хрватска
        </div>
    </div>
    <div class="state" id="bih" >
        <div class="flag" id="bihH" onmouseover="Himna(this.id)">
            <img src="img/bih.png" />
        </div>
        <div class="state-name" id="bihID" onclick="Drzava(this.id)">
            Б и Х
        </div>
    </div>
    <div class="state" id="bugarska">
        <div class="flag" id="bugarskaH" onmouseover="Himna(this.id)">
            <img src="img/bug.png" />
        </div>
        <div class="state-name" id="bugarskaID" onclick="Drzava(this.id)">
            Бугарска
        </div>
    </div>
    <div class="state" id="cg">
        <div class="flag" id="cgH" onmouseover="Himna(this.id)">
            <img src="img/cg.jpg" />
        </div>
        <div class="state-name" id="cgID" onclick="Drzava(this.id)">
            Црна Гора
        </div>
    </div>
    <div class="state" id="albanija">
        <div class="flag" id="albanijaH" onmouseover="Himna(this.id)">
            <img src="img/alb.png" />
        </div>
        <div class="state-name" id="albanijaID" onclick="Drzava(this.id)">
            Албанија
        </div>
    </div>
    <div class="state" id="makedonija">
        <div class="flag" id="makedonijaH" onmouseover="Himna(this.id)">
            <img src="img/mak.png" />
        </div>
        <div class="state-name" id="makedonijaID" onclick="Drzava(this.id)">
            Македонија
        </div>
    </div>
</body>
<script src="js/main.js"></script>
</html>
