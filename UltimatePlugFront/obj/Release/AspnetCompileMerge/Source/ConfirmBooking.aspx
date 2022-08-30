<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="ConfirmBooking.aspx.cs" Inherits="UtlimatePlug_FrontEnd.ConfirmBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:DropDownList ID="DropDownList1" runat="server" >  
            <asp:ListItem Value="">Accept/ Decline</asp:ListItem>  
            <asp:ListItem>Accept</asp:ListItem>  
            <asp:ListItem>Decline</asp:ListItem>
        </asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Done" OnClick="Button1_Click" />
    <label style="color:tomato" id="label1" runat="server"></label>
</asp:Content>
