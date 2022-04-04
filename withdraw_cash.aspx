<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="withdraw_cash.aspx.cs" Inherits="Practice_makes_perfect.withdraw_cash" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Current Balance: "></asp:Label>
&nbsp;&nbsp;
    <asp:Literal ID="ltrBalance" runat="server"></asp:Literal>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" ForeColor="Green" Text="Enter an amount equal to or less than the current balance"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Enter amount: "></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAmount" runat="server" Width="205px" CssClass="textbox"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Agent Number: "></asp:Label>
&nbsp;
    <asp:TextBox ID="txtAgentNumber" runat="server" Width="202px" CssClass="textbox"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Account Password:"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtPassword" runat="server" Width="178px" CssClass="textbox" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button8" runat="server" Text="Begin transaction" OnClick="Button8_Click" CssClass="button" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
