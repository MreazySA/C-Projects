<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="BestFriends.Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Banner Area -->
    <section class="banner-area organic-breadcrumb">
        <div class="container">
            <div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
                <div class="col-first">
                    <h1>Report</h1>
                    <nav class="d-flex align-items-center">
                        <a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Management<span class="lnr lnr-arrow-right"></span></a>
                        <a href="#">Report</a>
                    </nav>
                </div>
            </div>
        </div>
    </section>
    <!-- End Banner Area -->

    <!--================ Start Report Area =================-->
    <section class="cart_area" id="report">
        <div class="container">
            <div class="carT_inner">
                 <div class="table-responsive">
                    <div id="Enclosing_Div" runat="server">

                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
