<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="loans.aspx.cs" Inherits="Practice_makes_perfect.loans" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;    <asp:Label ID="Label3" runat="server" Text="Loan Limit:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrLoanLimit" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Loan Balance:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrBalance" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Request For A Loan" Width="153px" CssClass="button" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Pay For Loan" Width="164px" CssClass="button" />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
