<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="pay_for_loan.aspx.cs" Inherits="Practice_makes_perfect.pay_for_loan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Account Balance:"></asp:Label>
&nbsp;&nbsp;
    <asp:Literal ID="ltrbalance" runat="server"></asp:Literal>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Loan balance:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrLoanBalance" runat="server"></asp:Literal>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" ForeColor="Green" Text="To Pay for your loan, enter an amount less than or equal to your account balance"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Amount To Pay:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAmount" runat="server" Width="212px" TextMode="Number" CssClass="textbox"></asp:TextBox>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Account password:"></asp:Label>
&nbsp;<asp:TextBox ID="txtPassword" runat="server" Width="206px" TextMode="Password" CssClass="textbox"></asp:TextBox>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button8" runat="server" Text="Pay For Loan" Width="224px" OnClick="Button8_Click" CssClass="button" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
    <br />
&nbsp;
</asp:Content>
