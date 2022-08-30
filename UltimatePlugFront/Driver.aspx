<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Driver.aspx.cs" Inherits="WebApplication14UltimatePlugFront.Driver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <meta name="viewport" content="width=device-width, initial-scale=1">
<style>
body {font-family: Arial, Helvetica, sans-serif;}

/* Full-width input fields */
input[type=text], input[type=password] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}

/* Set a style for all <asp:Button runat="server" Text="Button"></asp:Button>s */
button {
  background-color: #04AA6D;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
}

button:hover {
  opacity: 0.8;
}

/* Extra styles for the cancel button */
.cancelbtn {
  width: auto;
  padding: 10px 18px;
  background-color: #f44336;
}

/* Center the image and position the close button */
.imgcontainer {
  text-align: center;
  margin: 24px 0 12px 0;
  position: relative;
}

img.avatar {
  width: 40%;
  border-radius: 50%;
}

.container {
  padding: 16px;
}

span.psw {
  float: right;
  padding-top: 16px;
}

/* The Modal (background) */
.modal {
 
  position: fixed; /* Stay in place */
  z-index: 1; /* Sit on top */
  left: 0;
  top: 0;
  width: 100%; /* Full width */
  height: 100%; /* Full height */
  overflow: auto; /* Enable scroll if needed */
  background-color: rgb(0,0,0); /* Fallback color */
  background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
  padding-top: 60px;
}

/* Modal Content/Box */
.modal-content {
  background-color: #fefefe;
  margin: 5% auto 15% auto; /* 5% from the top, 15% from the bottom and centered */
  border: 1px solid #888;
  width: 80%; /* Could be more or less, depending on screen size */
}

/* The Close Button (x) */
.close {
  position: absolute;
  right: 25px;
  top: 0;
  color: #000;
  font-size: 35px;
  font-weight: bold;
}

.close:hover,
.close:focus {
  color: red;
  cursor: pointer;
}

/* Add Zoom Animation */
.animate {
  -webkit-animation: animatezoom 0.6s;
  animation: animatezoom 0.6s
}

@-webkit-keyframes animatezoom {
  from {-webkit-transform: scale(0)} 
  to {-webkit-transform: scale(1)}
}
  
@keyframes animatezoom {
  from {transform: scale(0)} 
  to {transform: scale(1)}
}

/* Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
  span.psw {
     display: block;
     float: none;
  }
  .cancelbtn {
     width: 100%;
  }
}
</style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="id01" class="modal">

    <div class="container">
      <label for="uname"><b>Licence Number</b></label>
      <input type="text" id="LicenceNumber" runat="server" placeholder="Enter Licence Number" name="uname" required>

		<label for="uname"><b>Car Name</b></label>
      <input type="text" id="CarName" runat="server" placeholder="Enter Name/Brand" name="lname" required>

		   <label for="uname"><b>Number Plate</b></label>
      <input type="text" id="NumberPlate" runat="server" placeholder="Enter Registration Number" name="mail" required>
        
         <label for="uname"><b>Picture of The Car</b></label>
		       <br /> <asp:FileUpload ID="FileUpload1"  runat ="server"  />
        <br />
    <asp:Button ID="Button4" runat="server" Text="Preview your picture" OnClick="Button4_Click" />
         <br />
    <asp:Image ID="Image1" runat="server" Height = "100" Width = "100" />
    <br />

        <asp:Button ID="Button1" runat="server" Text="Create Account" class="btn btn-primary"  OnClick="CreateAccount" style="height: 26px" />

     
 
        
    </div>
  

    <!--
    <div class="container" style="background-color:#f1f1f1">
      <button type="button" onclick="document.getElementById('id01').style.display='none'" class="cancelbtn">Cancel</button>
      <span class="psw">Forgot <a href="#">password?</a></span>
    </div>
   -->
    <br />
    </div>
  
</asp:Content>
