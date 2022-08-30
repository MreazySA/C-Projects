<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication14UltimatePlugFront.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="stylesheet" href="StyleSheet1.css">
	<style>	    .align {
	        text-align: center;
	    }

	.button {
  border: none;
  outline: 0;
  display: inline-block;
  padding: 8px;
  color: white;
  background-color: #000;
  text-align: center;
  cursor: pointer;
  width: 100%;
}

.button:hover {
  background-color: #555;
}


.product-info{
	padding: 0 16px;
  text-align:center;
}

	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav class="product-filter">

		<div class="sort">
			<div class="collection-sort">
			
		    </select>
			
		</div>
	</nav>
		<div class="align">
		
		<h1>Products Available for Hire</h1>
		<p>Make your booking today</p>
			<br />
			<p>Welcome to Ultimate Plug</p>
	</div>
	<section class="products">
		<div class="product-card">
			<div class="product-image">
				<img src="pictures/xbox.jpg" style="width:100%">
			</div>
			<div class="product-info">
				<h2>Gaming</h2>
				  <a href="Gaming.aspx"><p class="button">See more<p/></a>
			</div>
		</div>
		
		<div class="product-card">
			<div class="product-image">
				<img src="pictures/pitch.jpg" style="width:100%">
			</div>
			<div class="product-info">
				<h2>Music</h2>
				  <a href="Music.aspx"><p class="button">See more<p/></a>
			</div>
		</div>
		
				<div class="product-card">
			<div class="product-image">
				<img src="pictures/EgyptianHubbly.png" style="width:100%">
			</div>
			<div class="product-info">
				<h2>Vibes</h2>
				  <a href="Vibes.aspx"><p class="button">See more<p/></a>
			</div>
		</div>
								<div class="product-card">
			<div class="product-image">
				<img src="pictures/Tent.jpeg" style="width:100%">
			</div>
			<div class="product-info">
				<h2>Events</h2>
				  <a href="Events.aspx"><p class="button">See more<p/></a>
			</div>
		</div>


						<div class="product-card">
			<div class="product-image">
				<img src="pictures/Car.jpg" style="width:100%">
			</div>
			<div class="product-info">
				<h2>Vehicles</h2>
				  <a href="Vehicles.aspx"><p class="button">See more<p/></a>
			</div>
		</div>

						<div class="product-card">
			<div class="product-image">
				<img src="pictures/Bulldozer.jpg" style="width:100%">
			</div>
			<div class="product-info">
				<h2>Construction</h2>
				  <a href="Construction.aspx"><p class="button">See more<p/></a>
			</div>
		</div>



	</section>
</asp:Content>
