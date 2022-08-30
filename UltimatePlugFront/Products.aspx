<%@ Page Title="" Language="C#" Mast erPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="UtlimatePlug_FrontEnd.Products" %>
	

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
html {
  box-sizing: border-box;
}

*, *:before, *:after {
  box-sizing: inherit;
}

img{
    float:left;
    width:350px;
    height:350px;
    object-fit:cover;
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
        <!--
               <h2>Responsive "Meet The Team" Section</h2>
<p>Resize the browser window to see the effect.</p>
<br>

<div class="row">
  <div class="column">
    <div class="card">
      <img src="root.png" alt="Jane" style="width:100%">
      <div class="container">
        <h2>Jane Doe</h2>
        <p class="title">CEO & Founder</p>
        <p>Some text that describes me lorem ipsum ipsum lorem.</p>
        <p>example@example.com</p>
        <p><button class="button">Contact</button></p>
      </div>
    </div>
  </div>

  <div class="column">
    <div class="card">
      <img src="root.png" alt="Mike" style="width:100%">
      <div class="container">
        <h2>Mike Ross</h2>
        <p class="title">Art Director</p>
        <p>Some text that describes me lorem ipsum ipsum lorem.</p>
        <p>example@example.com</p>
        <p><button class="button">Contact</button></p>
      </div>
    </div>
  </div>
  
  <div class="column">
    <div class="card">
      <img src="root.png" alt="John" style="width:100%">
      <div class="container">
        <h2>John Doe</h2>
        <p class="title">Designer</p>
        <p>Some text that describes me lorem ipsum ipsum lorem.</p>
        <p>example@example.com</p>
        <p><button class="button">Contact</button></p>
      </div>
    </div>
  </div>
</div>

        </div>-->

</asp:Content>
