<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="request_for_loan.aspx.cs" Inherits="Practice_makes_perfect.request_for_loan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Loan Limit:"></asp:Label>
&nbsp;&nbsp;
    <asp:Literal ID="ltrLoanLimit" runat="server"></asp:Literal>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" ForeColor="Green" Text="For fast processing of your loan, enter an amount less than or equal to your loan limit."></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Loan Request Amount:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtLoanAmount" runat="server" TextMode="Number" Width="194px" CssClass="textbox"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Account Password: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPassword" runat="server" Width="191px" CssClass="textbox" TextMode="Password"></asp:TextBox>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Process Loan" Width="222px" CssClass="button" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp; 
</asp:Content>
