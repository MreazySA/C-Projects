<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="BestFriends.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb">
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Edit</h1>
					<nav class="d-flex align-items-center">
						<a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Add User</a>
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
				<input type="text" class="form-control" id="firstName" name="name" placeholder="Name" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Name'" runat="server">
			</div>
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="lastName" name="surname" placeholder="Surame" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Surame'" runat="server">
			</div>
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="phoneNo" name="phoneno" placeholder="Phone Number" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Phone Number'" runat="server">
			</div>
			<div class="col-md-12 form-group">
				<input type="text" class="form-control" id="email" name="email" placeholder="Email Address" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Email Address'" runat="server">
			</div>
			<div class="col-md-12 form-group">
				<input type="password" class="form-control" id="pass" name="password" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'" runat="server">
			</div>
			<div class="col-md-12 form-group"> 
				<input type="password" class="form-control" id="confirmPass" name="confpass" placeholder="Confirm Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Confirm Password'" runat="server">
			</div>
            <div class="col-md-12 form-group" runat="server" id="Utype" visible="true">
				<label class="form-control">UserType</label>
				<br />
					<select class="form-control" id="userType" runat="server">
						<option selected value="0" >Customer</option>
						<option value="1">Admin</option>
						<option value="2">Manager</option>  
                    </select>                
            </div>
			<br />
			<br />
			<div class="col-md-12 form-group"> 
				<textarea class="form-control" id="msgErr" name="msgErr" rows="1" placeholder="" onfocus="this.placeholder = ''" onblur="this.placeholder = ''" visible="false" runat="server"></textarea>
			</div>
			<br />
			<br />
			<div class="col-md-12 form-group">
				<!-- <button type="submit" value="submit" class="primary-btn">Submit</button> -->
                <asp:Button ID="btnAdd" runat="server" value="submit" class="primary-btn" Text="Add" OnClick="btnAdd_Click" />
			</div>
			<br />
			<br />
			<br />
			<br />
		</form>
	</div>
</asp:Content>
