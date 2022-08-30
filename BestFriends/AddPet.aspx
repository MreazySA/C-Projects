<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddPet.aspx.cs" Inherits="BestFriends.EditPet" %>
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
		<h3>Add A New Pet</h3>
		<form class="row edit_form" action="#" method="post" id="contactForm" novalidate="novalidate" runat="server">
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="name" name="name" placeholder="Name" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Name'" runat="server">
			</div>
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="type" name="type" placeholder="Type of Pet" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Type of Pet'" runat="server">
			</div>
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="breed" name="breed" placeholder="Breed" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Breed'" runat="server">
			</div>
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="price" name="price" placeholder="Price" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Price'" runat="server">
			</div>
            <div class="col-md-12 form-group">
				<input type="text" class="form-control" id="path" name="image-path" placeholder="Image path" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Image path'" runat="server">
			</div>
            <div class="col-md-12 form-group">
				<input type="text" class="form-control" id="qty" name="qty" placeholder="Quantity" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Quantity'" runat="server">
			</div>
			<div class="col-md-12 form-group">
				<textarea class="form-control" id="message" name="message" rows="6" placeholder="" onfocus="this.placeholder = ''" onblur="this.placeholder = ''" runat="server"></textarea>
			</div>
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
