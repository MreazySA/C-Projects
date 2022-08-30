<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Vehicles.aspx.cs" Inherits="NewUltimateFE.Vehicles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
  <meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="stylesheet" href="StyleSheet1.css">
	<style>	    .align {
	        text-align: center;
	    }

	.button {
  border: none;
  outline: 0;
  display: inline-block;
  padding: 8px;
  color: white;
  background-color: #000;
  text-align: center;
  cursor: pointer;
  width: 100%;
}

.button:hover {
  background-color: #555;
}


.product-info{
	padding: 0 16px;
  text-align:center;
}

</style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   <br />
    <div class="align">
                      <h2>Vehicles available for Renting</h2>
<p>Make your booking today!</p>
<br>
        <input id="search"   runat="server" type="text" placeholder="What are you looking for?" />
          <asp:DropDownList ID="DropDownList1" runat="server" >  
            <asp:ListItem Value="" required="">Search Products by</asp:ListItem>  
            <asp:ListItem>NearMe</asp:ListItem>  
            <asp:ListItem>All</asp:ListItem>
              <asp:ListItem>City</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="searchProduct" />
        </div>
 <div id="display" runat="server"></div>
</asp:Content>
