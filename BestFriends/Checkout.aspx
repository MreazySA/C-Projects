<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="BestFriends.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb">
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Checkout</h1>
					<nav class="d-flex align-items-center">
						<a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Checkout</a>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->

	<!-- Edit Pet Start Area -->
	<div class="edit_form_whole">
		<h3>Billing Information</h3>
		<form class="row edit_form" action="#" method="post" id="contactForm" novalidate="novalidate" runat="server">
            <!--
            <div class="col-md-12 form-group">
				<input type="text" class="form-control" id="card" name="card" placeholder="Credit/Debit Card" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Credit/Debit Card'" runat="server">
			</div> 
            <br /> -->
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="cardno" name="cardno" placeholder="Card Number" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Number'" runat="server">
			</div>
            <!-- 
            <br />
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="cvv" name="cvv" placeholder="CVV (Security Code)" onfocus="this.placeholder = ''" onblur="this.placeholder = 'CVV (Security Code)'" runat="server">
			</div> 
            <div class="col-md-6 form-group">
				<input type="text" class="form-control" id="expiry" name="expiry" placeholder="Expires (mm/yyyy)" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Expires (mm/yyyy)'" runat="server">
			</div> -->
            <br />
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="addr1" name="addr1" placeholder="Street" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Street'" runat="server">
			</div>
            <!-- 
            <div class="col-md-12 form-group">
				<input type="text" class="form-control" id="addr2" name="addr2" placeholder="Street (Optional)" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Street (Optional)'" runat="server">
			</div> -->
            <br />
            <div class="col-md-12 form-group">
				<input type="text" class="form-control" id="city" name="city" placeholder="City/Suburb" onfocus="this.placeholder = ''" onblur="this.placeholder = 'City/Suburb'" runat="server">
			</div>
            <br />
            <div class="col-md-12 form-group">
				<input type="text" class="form-control" id="province" name="province" placeholder="Province" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Province'" runat="server">
			</div>
            <br />
            <div class="col-md-12 form-group">
				<input type="text" class="form-control" id="zip" name="zip" placeholder="PostCode" onfocus="this.placeholder = ''" onblur="this.placeholder = 'PostCode'" runat="server">
			</div>
			<br />
			<br />
			<div class="col-md-12 form-group">
                <textarea class="form-control" id="msgErr" name="msgErr" rows="2" placeholder="" onfocus="this.placeholder = ''" onblur="this.placeholder = ''" visible="false" runat="server"></textarea>
            </div>
            <br />
			<br />
			<div class="col-md-12 form-group">
                <asp:Button ID="btnToInvoice" runat="server" value="submit" class="primary-btn" Text="Finalise Purchase" OnClick="btnToInvoice_Click" />
			</div>
			<br />
			<br />
			<br />
			<br />
		</form>
	</div>
</asp:Content>
