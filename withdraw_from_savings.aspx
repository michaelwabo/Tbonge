<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="withdraw_from_savings.aspx.cs" Inherits="Practice_makes_perfect.withdraw_from_savings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Savings balance:"></asp:Label>
&nbsp;&nbsp;
    <asp:Literal ID="ltrSavings" runat="server"></asp:Literal>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp; Account balance:
    <asp:Literal ID="ltrBalance" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" ForeColor="Green" Text="Withdraw an amount less or equal to your savings balance"></asp:Label>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Amount To Withdraw:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAmount" runat="server" Width="194px" CssClass="textbox"></asp:TextBox>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Account Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPassword" runat="server" Width="193px" TextMode="Password" CssClass="textbox"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button8" runat="server" Text="Withdraw From Savings" Width="171px" OnClick="Button8_Click" CssClass="button" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
    <br />
    <br />
&nbsp;
</asp:Content>
