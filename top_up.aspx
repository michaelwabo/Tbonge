<%@ Page Title="" Language="C#" MasterPageFile="~/Agent.Master" AutoEventWireup="true" CodeBehind="top_up.aspx.cs" Inherits="Practice_makes_perfect.top_up" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label3" runat="server" Text="Fill your credit card details to buy more float"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Current float balance:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrFloat" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Amount to top up:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAmount" runat="server" Width="202px" OnTextChanged="txtAmount_TextChanged" TextMode="Number" CssClass="textbox"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Card number:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtcardNumber" runat="server" Width="234px" MaxLength="16" TextMode="Number" ToolTip="T6 numbers infront of your credit cardhe " CssClass="textbox"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="CSV:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCSV" runat="server" Width="235px" MaxLength="3" TextMode="Number" ToolTip="The 3 numbers behind your card" CssClass="textbox"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button9" runat="server" BackColor="Black" ForeColor="Gold" Text="Top up" Width="180px" OnClick="Button9_Click" CssClass="button" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMessage" runat="server" Text="."></asp:Label>
    <br />
    <br />
    <br />
</asp:Content>
