<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditPet.aspx.cs" Inherits="BestFriends.EditPet1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb" >
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Edit</h1>
					<nav class="d-flex align-items-center">
						<a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Management<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Edit Pet</a>
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
                        <h3>Pet</h3>
						<div class="hover">
                            <div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldName" name="oldname" placeholder="Name" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Name'" runat="server">
                                <br />
							</div>
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldType" name="oldtype" placeholder="Type" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Type'" runat="server">
                                <br />
							</div>
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldBreed" name="oldbreed" placeholder="Breed" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Breed'" runat="server">
                                <br />
							</div>
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldPrice" name="oldprice" placeholder="Price" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Price'" runat="server">
                                <br />
							</div>
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldImgPath" name="oldimgpath" placeholder="Image Path" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Image Path'" runat="server">
                                <br />
							</div>
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="oldQty" name="oldqty" placeholder="Quantity" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Quantity'" runat="server">
                                <br />
							</div>
                            <div class="col-md-12 form-group">
				                <textarea class="form-control" id="oldDesc" name="olddesc" rows="6" placeholder="Description" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Description'" runat="server">
                                </textarea>
                                <br />
			                </div>
						</div>
					</div>        
				 </div>		

                    <div class="col-lg-6">
                        <div class="edit_form_whole">
                            <h3>Update Pet</h3>
                            <form class="row edit_form" action="#" id="Form1" runat="server">
                                <div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newName" name="newname" placeholder="NEW Name" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Name'" runat="server">
                                    <br />
							    </div>
							    <div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newType" name="newtype" placeholder="NEW Type" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Type'" runat="server">
                                    <br />
							    </div>
							    <div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newBreed" name="newbreed" placeholder="NEW Breed" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Breed'" runat="server">
                                    <br />
							    </div>
							    <div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newPrice" name="newprice" placeholder="NEW Price" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Price'" runat="server">
                                    <br />
							    </div>
							    <div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newImgPath" name="newimgpath" placeholder="NEW Image Path" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Image Path'" runat="server">
                                    <br />
							    </div>
							    <div class="col-md-12 form-group">
								    <input type="text" class="form-control" id="newQty" name="newqty" placeholder="NEW Quantity" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Quantity'" runat="server">
                                    <br />
							    </div>
                                <div class="col-md-12 form-group">
				                    <textarea class="form-control" id="newDesc" name="newdesc" rows="6" placeholder="NEW Description" onfocus="this.placeholder = ''" onblur="this.placeholder = 'NEW Description'" runat="server">
                                    </textarea>
			                    </div>
							    <br />
							    <br />
							    <br />
							    <br />
                                <div class="col-md-12 form-group">
							        <!-- <button type="submit" value="submit" class="primary-btn">Create Account</button> -->
                                    <asp:Button ID ="btnEditPet" runat="server" Text="Submit Changes" class="primary-btn" OnClick="btnEditPet_Click" />
						        </div>
                            </form>
                        </div>
                    </div>    
			</div>
		</div>
	</section>
</asp:Content>
