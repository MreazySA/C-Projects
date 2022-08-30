<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="HireProduct.aspx.cs" Inherits="UtlimatePlug_FrontEnd.HireProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
  <meta name="viewport" content="width=device-width, initial-scale=1">
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <link rel="stylesheet" href="StyleSheet1.css">

<script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js"></script>

    <style>
        .align{
            text-align:center;
            
        }
        .product-info{
	padding: 0 16px;
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
    
    <div class="align">
                      <h2>Hire Product</h2>
        </div>
    <asp:Button ID="Button2" runat="server" class="button" Text="Back To Products" OnClick="Back" />

    <div id="display" runat="server">

    </div>
 <br />
 <br />  <div class="align">
                      <h2>Please Select date</h2>
        </div>
    <div style="width:100%; margin: 0 auto;">
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="100%">
 <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
    <TodayDayStyle BackColor="#CCCCCC" VerticalAlign="Middle" HorizontalAlign="Center" />
    
    </asp:Calendar><br />
    </div>
    <div class="align">
    <input type="text" id="time" runat="server" placeholder="Additional info . e.g Time">
    <br />
        <br />
          <asp:Button ID="Button1" runat="server" class="button" Text="Hire Product" OnClick="Button1_Click" />
        </div>

  
    					  <div id="hire" visible="false" runat="server">
    						 <script type="text/javascript">
                             swal("Hiring was Successful!", "The user will be notified!", "success");
                                 swal("Hiring was Successful!", "The user will be notified!", "success");

                             </script>
                              </div>

     <br />
        <br />
                              </asp:Content>
