<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="UtlimatePlug_FrontEnd.Home" %>
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
  text-align:center;
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

.align{
    text-align:center;
}



</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Hire" runat="server" Text="Hire" visible="false" OnClick="Hire_Click"/>
    <div class="align">
        <br />
                      <h2>Products available for Renting</h2>
<p>Make your booking today!</p>
<br>
        </div>
<div class="row">
  <div class="column">
    <div class="card">
      <img src="pictures/xbox.jpg" alt="xbox" style="width:100%">
      <div class="container">
        <h2>Gaming</h2>
       <a href="Gaming.aspx"><p class="button">See more<p/></a> 
      </div>
    </div>
  </div>


    <div class="row">
  <div class="column">
    <div class="card">
      <img src="pictures/pitch.jpg" alt="pitch" style="width:100%">
      <div class="container">
        <h2>Music</h2>
         <a href="Music.aspx"><p class="button">See more<p/></a> 
      </div>
    </div>
  </div>



    <div class="row">
  <div class="column">
    <div class="card">
      <img src="pictures/EgyptianHubbly.png" alt="hubbly" style="width:100%">
      <div class="container">
        <h2>Vibes</h2>
       <a href="Vibes.aspx"><p class="button">See more<p/></a> 
      </div>
    </div>
  </div>

        
    <div class="row">
  <div class="column">
    <div class="card">
      <img src="pictures/weddingTent.jpg" alt="pitch" style="width:100%">
      <div class="container">
        <h2>Events</h2>
        <a href="Events.aspx"><p class="button">See more<p/></a> 
      </div>
    </div>
  </div>


    <div class="row">
  <div class="column">
    <div class="card">
      <img src="pictures/Car.jpg" alt="vehicle" style="width:100%">
      <div class="container">
        <h2>Vehicles</h2>
         <a href="Vehicles.aspx"><p class="button">See more<p/></a> 
      </div>
    </div>
  </div>


        
    <div class="row">
  <div class="column">
    <div class="card">
      <img src="pictures/Bulldozer.jpg" alt="bulldozer" style="width:100%">
      <div class="container">
        <h2>Construction</h2>
          <a href="Construction.aspx"><p class="button">See more<p/></a> 
      </div>
    </div>
  </div>

        <br />
        <br />
        <div class="align">
            <h2>Testimonials</h2>
        </div>

        <!--Testimonials-->
        


</asp:Content>
