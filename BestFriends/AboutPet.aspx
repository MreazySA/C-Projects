<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AboutPet.aspx.cs" Inherits="BestFriends.AboutPet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb">
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Product Details Page</h1>
					<nav class="d-flex align-items-center">
						<a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="ShopCatalog.aspx">Shop<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">About Pet</a>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->

	<!--================Single Product Area =================-->
	<div class="product_image_area" id="about_pet">
		<div class="container">
			 <form id="form1" runat="server">
			<div class="row s_product_inner">
				<div class="col-lg-6">
					<div class="single-prd-item">
						 <img id="Image" src="*" style = "width:500px;height:516px" runat="server" />
						</div>
				</div>
				<div class="col-lg-5 offset-lg-1">
					<div class="s_product_text">
						<!--<h3>Fluffy</h3>-->
						<h3 id="pet_name" runat="server"/> 						
						<!--<h2>R149.99</h2>-->
						<h2 id="pet_price" runat="server"/>
						<ul class="list">
							<li><a class="active" id="pet_breed" runat="server"></a></li>
							<li><a class="active" id="pet_available" runat="server"></a></li>
						</ul>

						<p id="pet_info" runat="server"></p>
						
                        <!-- SHOWN AFTER A SESSION IS ACTIVE -->
						<div class="card_area d-flex align-items-center">
							<!--<a class="primary-btn" href="Cart.aspx" id="btn" runat="server" visible="false">Add to Cart</a>-->
							 <asp:Button id="btnAdd" runat="server" class="primary-btn" Text="Add to cart" OnClick="btnAdd_Click" />
							 <br />
							 <asp:Button id="Back" runat="server" class="gray_btn" Text="Back to Shop" OnClick="Back_Click" />
						</div>						 					
					</div>
				</div>
			</div>
		  </form>
		</div>
	</div>
	
	<br />
	<br />
	<br />
	<br />
	<br />
</asp:Content>
