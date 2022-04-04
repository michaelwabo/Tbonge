<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="add_to_savings.aspx.cs" Inherits="Practice_makes_perfect.add_to_savings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Current  Account Balance:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Literal ID="ltrBalance" runat="server"></asp:Literal>
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Current Savings Balance:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Literal ID="ltrSavings" runat="server"></asp:Literal>
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" ForeColor="Green" Text="Enter an amount less than or equal to your current balance"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Amount To Save: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAmount" runat="server" Width="192px" TextMode="Number" CssClass="textbox"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Account Password:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtPassword" runat="server" Width="188px" TextMode="Password" CssClass="textbox"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" Text="Add To Savings" Width="186px" OnClick="Button8_Click" CssClass="button" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    
</asp:Content>
