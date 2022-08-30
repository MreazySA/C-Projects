<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="CancelBooking.aspx.cs" Inherits="WebApplication14UltimatePlugFront.CancelBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
  <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
             .align{
          text-align:center;
         
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
      <br />
        <br />     <br />
    <div class="align">
                      <h2>Cancel Booking?</h2>
<p>Choose Option</p>
         <asp:DropDownList ID="DropDownList1" runat="server" >  
            <asp:ListItem Value="">Are you sure you want to Cancel?</asp:ListItem>  
            <asp:ListItem>Yes</asp:ListItem>  
            <asp:ListItem>No</asp:ListItem>
            
        </asp:DropDownList>
         <br />
             <label style="color:black" id="label1" runat="server"></label>
<br></div>
   
    <br /> <br />
    <asp:Button ID="Button1" runat="server" class="button" Text="Done" OnClick="Button1_Click" />
    
</asp:Content>
