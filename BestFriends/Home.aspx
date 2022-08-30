<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BestFriends.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<!-- start banner Area -->
	<section class="banner-area">
		<div class="container">
			<div class="row fullscreen align-items-center justify-content-start">
				<div class="col-lg-12">
					<div class="active-banner-slider owl-carousel">
						<!-- single-slide -->
						<div class="row single-slide align-items-center d-flex">
							<div class="col-lg-5 col-md-6">
								<div class="banner-content">
									<h1>Best Friends.</h1>
									<p>Our goal is to provide you to expand your family with our store selected dogs and cats you deserve, 
										at a price you can afford, in South Africa!</p>
								</div>
							</div>
						</div>
						<!-- single-slide -->
						<div class="row single-slide">
							<div class="col-lg-5">
								<div class="banner-content">
									<h1>Explore Our <br> Cats </h1>
									<p>Go through our shop full of felines right here</p>
									<div class="add-bag d-flex align-items-center">
										<a class="add-btn" href="Cats.aspx"><span class="lnr lnr-cross"></span></a>
										<span class="add-text text-uppercase">Explore</span>
									</div>
								</div>
							</div>
						</div>
						<!-- single-slide -->
						<div class="row single-slide">
							<div class="col-lg-5">
								<div class="banner-content">
									<h1>Not a fan of our <br> Cats? </h1>
									<p>Take a look at our Dogs section</p>
									<div class="add-bag d-flex align-items-center">
										<a class="add-btn" href="Dogs.aspx"><span class="lnr lnr-cross"></span></a>
										<span class="add-text text-uppercase">Explore</span>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!-- End banner Area -->
	<div style="padding:100px 150px 0px 150px ">
        <div class="row justify-content-center">
            <div class="col-lg-6 text-center">
                <div class="section-title">
                    <h1>Latest Breed</h1>
					<p>Stay ahead of the pack and learn about the newest breeds of dogs and cats around, 
					    as well as the new crossbreeds of these pets lovers are welcoming 
                        into their homes.
					</p>
                    <p>&nbsp;</p>
                    <p>&nbsp;</p>
                   
          
                    </div>
			    </div>
		    </div>
			 <div id="Enclosing_Div" runat="server">
	    </div>
	</div>
</asp:Content>
