<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="send_money.aspx.cs" Inherits="Practice_makes_perfect.send_money" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Current Balance: "></asp:Label>
&nbsp;&nbsp;
    <asp:Literal ID="ltrBalance" runat="server"></asp:Literal>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" ForeColor="Green" Text="To send money, enter an amount equal or less than the current balance"></asp:Label>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Amount to send:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAmount" runat="server" Width="193px" CssClass="textbox"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Phone number to send to:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPhone" runat="server" Width="191px" CssClass="textbox"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Account Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPassword" runat="server" Width="189px" TextMode="Password" CssClass="textbox"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Begin Transaction" Width="157px" CssClass="button" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
    <br />
&nbsp;
</asp:Content>
