<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="BestFriends.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


	   <!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb">
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Search Pet</h1>
					<nav class="d-flex align-items-center">
						<a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Search</a>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->

    <!-- Search Area Start-->
    <section class="user_box_area section_gap" id="userLogin" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
					<div class="user_form_inner">
						<h3>Search</h3> 
						<form class="row user_form" action="#" runat="server">
							<div class="col-md-12 form-group">
								<input type="text" class="form-control" id="search" name="search" onfocus="this.placeholder = ''" runat="server">
							</div>
							<br />
							<br />
							<br />
							<div class="col-md-12 form-group">
                                <asp:Button ID ="btnSearch" runat="server" value="submit" Text ="Search" class="primary-btn" OnClick="btnSearch_Click" />
							</div>
							<br />
							<br />
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
