<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BestFriends.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb" >
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Register</h1>
					<nav class="d-flex align-items-center">
						<a href="#">Register</a>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->

	<!--================Register Box Area =================-->
	<section class="user_box_area section_gap" id="userReg">
		<div class="container">
			<div class="row">
				<div class="col-lg-6">
					<div class="user_box_img">
						<div class="hover">
							<h4>Existing customer?</h4>
							<p>Log in to add your favourite pets on your shopping cart.</p>
							<a class="primary-btn" href="Login.aspx" runat="server">Sign In</a>
						</div>
					</div>
					<br />
					<br />
					<br />
					<br />
				</div>
				
				<div class="col-lg-6">
					<div class="user_form_inner">
						<h3>Register</h3>
						<form class="row user_form" action="#" method="post" id="contactForm" novalidate="novalidate" runat="server">
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
                            <div class="col-md-12 form-group" runat="server" id="Utype" visible="false">
                              <label class="tableview" >UserType</label>
                                <br />
                                <select class="tableview" id="userType" runat="server">
                                   <option selected value="0" >Customer</option>
                                   <option value="1">Admin</option>
                                   <option value="2">Manager</option>  
                                </select>                
                             </div>
							<br />
							<br />
							<textarea class="form-control" id="msgErr" name="msgErr" rows="1" placeholder="" onfocus="this.placeholder = ''" onblur="this.placeholder = ''" visible="false" runat="server"></textarea>
							<br />
							<br />
							<div class="col-md-12 form-group">
								<!-- <button type="submit" value="submit" class="primary-btn">Create Account</button> -->
                                <asp:Button ID ="btnRegister" runat="server" Text="Create Account" class="primary-btn" OnClick="BtnReg_Click" />
							</div>
							<br />
							<br />
							<br />
							<br />
						</form>
					</div>
				</div>
			</div>
		</div>
	</section>
</asp:Content>
