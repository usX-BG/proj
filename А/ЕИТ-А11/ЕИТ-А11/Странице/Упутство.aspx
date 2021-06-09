<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Почетна.aspx.cs" Inherits="ЕИТ_А11.Почетна" %>

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
		<meta http-equiv="X-UA-Compatible" content="IE=edge" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<!-- WEB FONTS -->
		<link href='http://fonts.googleapis.com/css?family=Roboto:100,300,100italic,400,300italic' rel='stylesheet' type='text/css' />
		<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300' rel='stylesheet' type='text/css' />
		<!-- BOOTSTRAP -->
		<link href="../css/bootstrap.min.css" rel="stylesheet" />
		<!-- FONT AWESOME -->
		<link rel="stylesheet" href="../css/font-awesome.min.css" />
		<!-- CUSTOM STYLING -->
		<link href="../css/styles.css" rel="stylesheet" />
		<!-- PRELOADER -->	
		<link href="../css/loader.css" rel="stylesheet" />
        <title>Нумеролошко слагање</title>
        <link rel="icon" href="../Слике/favicon.ico"/>
</head>
<body>
    <!-- PRELOADER -->
		<div id="loader-wrapper">
			<div id="loader"><div class="sk-spinner sk-spinner-cube-grid"><div class="sk-cube"></div><div class="sk-cube"></div><div class="sk-cube"></div><div class="sk-cube"></div><div class="sk-cube"></div><div class="sk-cube"></div><div class="sk-cube"></div><div class="sk-cube"></div><div class="sk-cube"></div></div></div>
		</div>	
		
	<!-- HEADER -->
		<section id="header">
			<div class="container">
				<div class="row text-center">
					<div class="col-md-8">
						<img class="logo" src="../Слике/favicon.ico" />
						<h1 class="white-text">Добродошли на сајт ,,Нумеролошко слагање"</h1>
						<h5 class="white-text">Сазнајте колико се слажете са неким ;)</h5>
						<div id="countdown" class="white-text"></div>
					</div>
				</div>
			</div>
			<div class="animation">
			<a class="arrow-down-animation" href="#about"><i class="fa fa-angle-down"></i></a>
			</div>
		</section>
	<!-- HEADER ENDS -->
    <!-- ABOUT -->
		<section id="about">
			<div class="container">
				<div class="row text-center">
					<!-- Section 1 -->
					<a href="../Почетна.aspx"><div data-sr="enter top over 1s, wait 0.3s, move 24px, reset" class="col-md-4">
						<i class="fa fa-laptop"></i>
						<h3>Почетна</h3>
						<div class="colored-line-small-center"></div>
						<p>Сазнајте колико се слажете са неким.</p>
					</div></a>
					<!-- Section 2 -->
					<a href="Упутство.aspx"><div data-sr="enter bottom over 1s, wait 0.3s, move 24px, reset" class="col-md-4 middle">
						<i class="fa fa-lightbulb-o"></i>
						<h3>Упутство</h3>
						<div class="colored-line-small-center"></div>						
						<p>Ако не знате како се ово користи, погледај упутво.</p>						
					</div></a>
					<!-- Section 3 -->
					<a href="О_аутору.aspx"><div data-sr="enter top over 1s, wait 0.3s, move 24px, reset" class="col-md-4">
						<i class="fa fa-newspaper-o"></i>
						<h3>О аутору</h3>
						<div class="colored-line-small-center"></div>
						<p>Сазнајте ко је направио ово ремек дело.</p>						
					</div></a>
				</div>
			</div>			
		</section>
	<!-- ABOUT ENDS -->
	
		<section id="subscribe" style="font-weight:bolder;font-size:22px;">
			Унесите име своје и име другога свога пријатеља/симпија/дефојке/друга/итд. Кад сте то унели сазнајте датум рођ те осопе (ко још користи фб има тамо).
            Након тога унесите датуме свог и њеног/његовог рођењу у означене за то улазе. Обавезно следите формат (пример: 05.06.2001.).
		</section>
			
	<!-- CONTACT ENDS -->
	
	<!-- FOOTER -->
		<footer id="footer">
			<div class="container">
				<div class="row text-center">	
					<p>
						&copy; 2021 Нумеролошко слагање | Дизајнирао <a href="https://muharemovic.com">Мартин</a>
						<span class="social">
							<a href="#"><i class="fa fa-facebook-square"></i></a>
							<a href="#"><i class="fa fa-twitter-square"></i></a> 
							<a href="#"><i class="fa fa-google-plus-square"></i></a>
						</span>
					</p>
				</div>
			</div>		
		</footer>
	<!-- FOOTER ENDS -->	

	
		<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
		<!-- Include all compiled plugins (below), or include individual files as needed -->
		<script src="../js/bootstrap.min.js"></script>
		<!-- SMOOTH SCROLL -->
		<script src="../js/smooth-scroll.min.js"></script>
		<!-- PARALLAX IMG -->
		<script src="../js/jquery.parallax-1.1.3.js"></script>
		<!-- SCROLL REVEAL -->
		<script src="../js/scrollReveal.min.js"></script>
		<!-- FUNCTIONS -->
		<script src="../js/functions.js"></script>
</body>
</html>
