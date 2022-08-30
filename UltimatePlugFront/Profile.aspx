<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="NewUltimateFE.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
        .align{
            text-align:center;
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
    <br />
    <div class="align">
       <asp:Button ID="Button1" runat="server" Text="View Transactions" OnClick="Button1_Click" />
    <br />
    <div id="viewTrans" runat="server"></div>
    <br />
 
</asp:Content>
