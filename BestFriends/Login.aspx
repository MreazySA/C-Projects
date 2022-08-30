<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BestFriends.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb">
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Login</h1>
					<nav class="d-flex align-items-center">
						<a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Login</a>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->

	<!--================Login Box Area =================-->
	<section class="user_box_area section_gap" id="userLogin" runat="server">
		<div class="container">
			<div class="row">
				<div class="col-lg-6">
					<div class="user_form_inner">
						<h3>Log in to enter</h3> 
						<form class="row user_form" action="#" runat="server">
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="email" name="email" placeholder="Email" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Email'" runat="server">
							</div>
							<div class="col-md-12 form-group">
								<input type="password" class="form-control" id="pass" name="password" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'" runat="server">
							</div>
							<br />
							<br /><textarea class="form-control" id="msgErr" name="msgErr" rows="1" placeholder="" onfocus="this.placeholder = ''" onblur="this.placeholder = ''" visible="false" runat="server"></textarea>
							<br />
							<br />
							<div class="col-md-12 form-group">
								<!-- <button type="submit" value="submit" class="primary-btn" runat="server">Log In</button> -->
                                <asp:Button ID ="btnLogin" runat="server" value="submit" Text ="Log In" class="primary-btn" OnClick="BtnSend_Click" />
							</div>
							<br />
							<br />
							<br />
							<br />
						</form>
                    </div>
				</div>
				
				<div class="col-lg-6">
					<div class="user_box_img">
						<div class="hover">
							<h4>New to our website?</h4>
							<p>Create an account now and explore a variety of pets we have on offer.</p>
							<a class="primary-btn" href="Register.aspx" runat="server">Create an Account</a>
						</div>
					</div>
					<br />
					<br />
					<br />
					<br />
				</div>
			</div>
        </div>
	</section>
</asp:Content>
