<%@ Page Title="" Language="C#" MasterPageFile="~/Business.Master" AutoEventWireup="true" CodeBehind="business_profile.aspx.cs" Inherits="Practice_makes_perfect.business_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label3" runat="server" Text="Business Account profile"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Business Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrBusinessName" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Business Id:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrBusinessId" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp; Bank balance:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrBalance" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Country:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrCountry" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Address:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrAddress" runat="server"></asp:Literal>
    <br />
    <br />
    <br />
</asp:Content>
