<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="UtlimatePlug_FrontEnd.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.css" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js"></script>


    <style>

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
        table {

  border-collapse: collapse;
  border-spacing: 0;
  width: 100%;
  border: 1px solid #ddd;
}

th, td {
  text-align: left;
  padding: 16px;
}

tr:nth-child(even) {
  background-color: tomato;
}
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="align">
    <asp:Button ID="Button1" runat="server" Text="View Transactions" onClick="Transactions"/>
    <br />
    <div id="viewTrans" runat="server"></div>
    <br />

    <asp:Button ID="Button2" runat="server" Text="Add Product" onClick="Add" />
    <div id="showProducts" runat="server" visible="false">
    <br />
    <input id="ProductName" type="text" placeholder="Product Name" runat="server"/>
    <br />
    <br />
       <asp:DropDownList ID="DropDownList1" runat="server" >  
            <asp:ListItem Value="">Please Select Category</asp:ListItem>  
            <asp:ListItem>Gaming</asp:ListItem>  
            <asp:ListItem>Music</asp:ListItem>
       <asp:ListItem>Vibes</asp:ListItem>
                  <asp:ListItem>Events</asp:ListItem>   
           <asp:ListItem>Vehicles</asp:ListItem>
                  <asp:ListItem>Construction</asp:ListItem>
                 

        </asp:DropDownList>
    <br />
         <div class="container">
      <input id="price" type="text" placeholder="Product Price" runat="server"/>
    <br />
      <input id="description" type="text" placeholder="Product Description" runat="server"/>
    <br />
        </div>
    <asp:FileUpload ID="FileUpload1" runat="server"  />
   
    <br />
    <asp:Button ID="Button4" runat="server" Text="upload" OnClick="Button4_Click" />
    <br />
    <asp:Image ID="Image1" runat="server" Height = "500" Width = "500" />
    <br />
    <div id="showImage" runat="server"></div>
        <br />
    <asp:Button ID="Button3" runat="server" Text="Add" OnClick="AddProduct" />
        <br />
        <br />

          <div id="show" visible="false" runat="server">
    						 <script type="text/javascript">
                                 swal("Product Added!", "Successfully", "success");
                               //  swal("Hiring was Successful!", "The user will be notified!", "success");

                             </script>
                              </div>

    </div>
        					

</asp:Content>
