
<!--
Author: W3layouts
Author URL: http://w3layouts.com
Edited by: David Rodrigues 14872 IPCA
-->
<!DOCTYPE html>
<html lang="zxx">

<head>
  <!-- Required meta tags -->
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <title> Webzine Entertainment & Blog Category Responsive Website Template | Home </title>
  <!-- Template CSS -->
  <link rel="stylesheet" href="assets/css/style-starter.css">
  <!-- Template CSS -->
  <link href="//fonts.googleapis.com/css?family=Playfair+Display:400,400i,700&display=swap" rel="stylesheet">
  <link href="//fonts.googleapis.com/css?family=Montserrat:300,300i,400,600,700,800&display=swap" rel="stylesheet">
  <!-- Template CSS -->


</head>

<body>
<!-- Headers-4 block -->
<section class="w3l-header-6-main mobile-header">
    <div class="header-section-hny">
        <div class="header-top">
            <div class="container">
                <!-- /header-top-inn-->
                <div class="header-inn-top row">
                    <div class="logo-brand col-12">
                        <a class="navbar-brand" style="color:white;" href="index.html">
                            PRAZER INVULGAR
                        </a>
					</div>
                </div>
                <!-- //header-top-inn-->
            </div>
        </div>
        
    </div>
</section>
<section class="w3l-mag-main">
	<!--/mag-content-->
	<div class="mag-content-inf py-5">
		<div class="container">
			<div class="banner-bottom-sechny py-md-4">
				<h3 class="hny-title text-center">Notícias <span>Recentes</span></h3>
				<div class="ban-content-inf row py-lg-3">
					<div class="maghny-gd-1 col-lg-6">
						<div class="maghny-grid">
							<figure class="effect-lily">
								<img class="img-fluid" src="assets/images/grid20.jpg" alt="">
								<figcaption class="w3set-hny">
									<div>
										<h4 class="top-text">Man in black jacket and brown hat standing on rock
											<span>near lake</span></h4>
										<p>Jan.20.2020 </p>
									</div>

								</figcaption>
							</figure>
						</div>
					</div>
					<div class="maghny-gd-1 col-lg-6">
						<div class="row">
							<div class="maghny-gd-1 col-md-6">
								<div class="maghny-grid">
									<figure class="effect-lily">
										<img class="img-fluid" src="assets/images/grid7.jpg">
										<figcaption>
											<div>
												<h4>woman near <span>pigeons</span></h4>
												<p>Jan.20.2020 </p>
											</div>

										</figcaption>
									</figure>
								</div>
								<h5 class="top-title"><a href="#">There are many variations that focuses on
										presenting</a></h5>

								<div class="mag-post-meta mt-3"><span
										class="meta-author text-uppercase"><span>By&nbsp;</span><a href="#"
											class="author-name"> John
											Brain</a> </span>
									<span class="author-date">Jan 5, 2020</span>
								</div>
								<a href="#" class="read-more btn mt-3">Read More</a>
							</div>
							<div class="maghny-gd-1 col-md-6">
								<div class="maghny-grid">
									<figure class="effect-lily">
										<img class="img-fluid" src="assets/images/grid8.jpg">
										<figcaption>
											<div>
												<h4>Man standing on railroad near <span>plants</span></h4>
												<p>Jan.20.2020 </p>
											</div>

										</figcaption>
									</figure>
								</div>
								<h5 class="top-title"><a href="#">
										There are many variations that focuses on presenting</a></h5>
								<div class="mag-post-meta mt-3"> <span
										class="meta-author text-uppercase"><span>By&nbsp;</span><a href="#"
											class="author-name"> John
											Brain</a> </span>
									<span class="author-date">Jan 5, 2020</span>
								</div>
								<a href="#" class="read-more btn mt-3">Read More</a>
							</div>
						</div>
					</div>
				</div>
			</div>
			<div class="blog-inner-grids py-md-4 row">
				<div class="mag-content-left-hny col-lg-12">
					<!--/mag-hny-content-1-->
					<div class="mag-hny-content">
						<h3 class="hny-title">Artigos <span>Recentes</span></h3>
						<!--/mag-left-grid-1-->
						<div class="maghny-grids-inf row">
						<?php
							// Get the contents of the JSON file 
							$strJsonFileContents = file_get_contents("json/dados.json");
							$array = json_decode($strJsonFileContents, true);
							foreach($array["data"] as $post){
						?>
							<div class="maghny-gd-1 col-lg-4 col-md-6">
								<div class="maghny-grid">
									<figure class="effect-lily">
										<img class="img-fluid" src="<?php echo $post['media_url']; ?>" alt="">
										<figcaption>
										</figcaption>
									</figure>
								</div>
								<h5><a href="#">
										<?php echo substr($post['caption'], 0, 50)."..."; ?></a></h5>

							</div>
						<?php } ?>
						</div>
					</div>
				</div>
			</div>
			<!--/newsletter-->
			<div class="form-inner-newsletter py-lg-5">

				<div class="newsletter-infhny p-md-5 p-4">
					<div class="newsletter-inn-con p-lg-5">
						<p>QUEREMOS PARTILHAR CONTIGO AS NOVIDADES</p>
						<h2>SUBCREVE A NOSSA NEWSLETTER!</h2>

						<form action="#" method="post" class="newsletter-form mt-md-5">
							<div class="form-input">
								<input type="email" name="email" class="form-control"
									placeholder="Enter your email address" required="">
							</div>
							<div class="form-input mt-md-4 mt-3"><button class="btn">Subscribe</button></div>
						</form>
					</div>
				</div>
			</div>
			<!--//newsletter-->
		</div>
	</div>
	<!--//mag-content-->
	<!-- /slider -->
	<script src="assets/js/jquery-3.3.1.min.js"></script>
	<script src="assets/js/grids.owl.carousel.js"></script>
	<script>
		$(document).ready(function () {
			$('.owl-carousel').owlCarousel({
				loop: true,
				margin: 0,
				responsiveClass: true,
				autoplay: true,
				autoplayTimeout: 2000,
				autoplaySpeed: 1000,
				autoplayHoverPause: true,
				responsive: {
					0: {
						items: 1,
						nav: false
					},
					480: {
						items: 2,
						nav: true,
						margin: 20
					},
					667: {
						items: 3,
						nav: true,
						margin: 20
					},
					1000: {
						items: 5,
						nav: true,
						margin: 20
					}
				}
			})
		})
	</script>
	<!-- /slider -->
</section>
<!-- footer-66 -->
<footer class="w3l-footer-66">
    <div class="below-section">
        <div class="container">
            <div class="copyright-footer text-center">

                <p>© 2020 Webzine. All rights reserved.| Design by
					<a href="http://w3layouts.com/" target="_blank">W3layouts</a>
                </p>
            </div>
        </div>
        <!-- move top -->
        <button onclick="topFunction()" id="movetop" title="Go to top">
            <span class="fa fa-arrow-up" aria-hidden="true"></span>
        </button>
        <script>
            // When the user scrolls down 20px from the top of the document, show the button
            window.onscroll = function () {
                scrollFunction()
            };

            function scrollFunction() {
                if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
                    document.getElementById("movetop").style.display = "block";
                } else {
                    document.getElementById("movetop").style.display = "none";
                }
            }

            // When the user clicks on the button, scroll to the top of the document
            function topFunction() {
                document.body.scrollTop = 0;
                document.documentElement.scrollTop = 0;
            }
        </script>
        <!-- /move top -->
    </div>
    <!-- copyright -->



</footer>
<!--//footer-66 -->
</body>

</html>
