<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdatePet.aspx.cs" Inherits="BestFriends.UpdatePet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Banner Area -->
    <section class="banner-area organic-breadcrumb">
        <div class="container">
            <div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
                <div class="col-first">
                    <h1>Update</h1>
                    <nav class="d-flex align-items-center">
                        <a href="Home.aspx">Home<span class="lnr lnr-arrow-right"></span></a>
						<a href="#">Management<span class="lnr lnr-arrow-right"></span></a>
                        <a href="#">Update Pet</a>
                    </nav>
                </div>
            </div>
        </div>
    </section>
    <!-- End Banner Area -->

    <!--================ Update Pet Area =================-->
    <section class="cart_area" id="update_pet">
        <div class="container">
            <form class="#" action="#" method="post" id="contactForm" novalidate="novalidate" runat="server">
                <div class="cart_inner">
                    <div class="table-responsive">
                        <div id="Enclosing_Div" runat="server">
       
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </section>
</asp:Content>
