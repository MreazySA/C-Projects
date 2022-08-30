<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="ProductPage.aspx.cs" Inherits="NewUltimateFE.ProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
	<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
html {
  box-sizing: border-box;
}

*, *:before, *:after {
  box-sizing: inherit;
}

.column {
  float: left;
  width: 33.3%;
  margin-bottom: 16px;
  padding: 0 8px;
}

@media screen and (max-width: 650px) {
  .column {
    width: 100%;
    display: block;
  }
}

.card {
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
}

.container {
  padding: 0 16px;
}

.container::after, .row::after {
  content: "";
  clear: both;
  display: table;
}

.title {
  color: grey;
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
</style>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
            <h2>Responsive "Meet The Team" Section</h2>
<p>Resize the browser window to see the effect.</p>
<br>
<h1>Products for Hiring</h1>
   
   <asp:DropDownList ID="DropDownList1" runat="server" >  
            <asp:ListItem Value="">Please Select Category</asp:ListItem>  
            <asp:ListItem>ENTERTAINMENT</asp:ListItem>  
            <asp:ListItem>EVENT</asp:ListItem>
       <asp:ListItem>INDOOR</asp:ListItem>
        </asp:DropDownList>
    <br />
    
    <asp:Button ID="Button1" runat="server" Text="Search Category" OnClick ="ChooseProduct" />
    <div id="display" runat="server"></div>
        
</asp:Content>
