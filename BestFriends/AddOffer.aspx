<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddOffer.aspx.cs" Inherits="BestFriends.AddOffer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb">
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Edit Pet</h1>
					<nav class="d-flex align-items-center">
						<a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Add Pet</a>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->

	<!-- Edit Pet Start Area -->
	<div class="edit_form_whole">
		<h3>Add An Offer</h3>
		<form class="row edit_form" action="#" method="post" id="contactForm" novalidate="novalidate" runat="server">
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="title" name="title" placeholder="Totle" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Title'" runat="server">
			</div>
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="type" name="type" placeholder="Type" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Type'" runat="server">
			</div>
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="imgfile" name="imgfile" placeholder="Image Path" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Image Path'" runat="server">
			</div>
			<textarea class="form-control" id="description" name="description" rows="6" placeholder="" onfocus="this.placeholder = ''" onblur="this.placeholder = ''" runat="server"></textarea>
			<br />
			<br />
			<textarea class="form-control" id="msgErr" name="msgErr" rows="1" placeholder="" onfocus="this.placeholder = ''" onblur="this.placeholder = ''" visible="false" runat="server"></textarea>
			<br />
			<br />
			<div class="col-md-12 form-group">
				<!-- <button type="submit" value="submit" class="primary-btn">Submit</button> -->
                <asp:Button ID="btnAdd" runat="server" value="submit" class="primary-btn" Text="Add" OnClick="BtnAdd_Click" />
			</div>
			<br />
			<br />
			<br />
			<br />
		</form>
	</div>
</asp:Content>
