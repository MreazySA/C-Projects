<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="BestFriends.EditUser" %>
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
						<a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Edit User</a>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->

	<!--================Register Box Area =================-->
	<section class="edit_box_area section_gap" id="edit">
		<div class="container">
			<div class="row">
                <div class="col-lg-6">
                    <div class="edit_form_whole">
                        <h3>User</h3>
						<div class="hover">
                            <div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldName" name="oldname" placeholder="Name" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Name'" runat="server">
							</div>
                            <br />
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldSurname" name="oldsur" placeholder="Surname" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Surname'" runat="server">
							</div>
                            <br />
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldNumber" name="oldnum" placeholder="Phone Number" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Phone Number'" runat="server">
							</div>
                            <br />
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldEmail" name="oldemail" placeholder="Email Address" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Email Address'" runat="server">
							</div>
							<br />
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldusertype" name="oldusertype" placeholder="User Type" onfocus="this.placeholder = ''" onblur="this.placeholder = 'User Type'" runat="server">
							</div>
                            <br />
						</div>
					</div>        
				 </div>		

                    <div class="col-lg-6">
                        <div class="edit_form_whole">
                            <h3>Update User</h3>
                            <form class="row edit_form" action="#" id="Form1" runat="server">
                                <div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newName" name="newname" placeholder="NEW Name" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Name'" runat="server">
							    </div>
                                <br />
							    <div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newSurname" name="newsur" placeholder="NEW Surname" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Surname'" runat="server">
							    </div>
                                <br />
							    <div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newNumber" name="newnum" placeholder="NEW Phone Number" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Phone Number'" runat="server">
							    </div>
                                <br />
							    <div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newEmail" name="newemail" placeholder="NEW Email Address" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Email Address'" runat="server">
							    </div>
								<div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newusertype" name="newusertype" placeholder="NEW User Type" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW User Type'" runat="server">
							    </div>
							    <br />
							    <br />
							    <br />
							    <br />
                                <div class="col-md-12 form-group">
							        <!-- <button type="submit" value="submit" class="primary-btn">Create Account</button> -->
                                    <asp:Button ID ="btnEditUser" runat="server" Text="Submit Changes" class="primary-btn" OnClick="btnEditUser_Click" />
						        </div>
                            </form>
                        </div>
                    </div>    
			</div>
		</div>
	</section>
</asp:Content>
