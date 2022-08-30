<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ReportsPage.aspx.cs" Inherits="BestFriends.ReportsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb" >
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>View Transaction Reports</h1>
					<nav class="d-flex align-items-center">
						<a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Management<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Reports</a>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->

    <!-- Start Report Page Area-->
    <section class="cart_area">
        <div class="container">
            <div class="cart_inner">
                <div class="table-responsive">
                    <table class="table">
                        <thead>
                            <tr>
                                <th scope="col">Report</th>
                                <th scope="col">View</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <div class="media">
                                        <div class="media-body">
                                            <p>Daily Transactions</p>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <a href ="Report.aspx?type=day">
								        <img src='img/view.png' alt='view'>       
								    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="media">
                                        <div class="media-body">
                                            <p>Monthly Transactions</p>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <a href ="Report.aspx?type=month">
								        <img src='img/view.png' alt='view'>       
								    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class="media">
                                        <div class="media-body">
                                            <p>Annual Transactions</p>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <a href ="Report.aspx?type=year">
								        <img src='img/view.png' alt='view'>       
								    </a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
