<%@ Page Title="" Language="C#" MasterPageFile="~/Agent.Master" AutoEventWireup="true" CodeBehind="agent_profile.aspx.cs" Inherits="Practice_makes_perfect.agent_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label3" runat="server" Text="Agent account profie details"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Agent Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrAgentName" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Agent Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrAgentNumber" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Float Balance:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrFloatBalance" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Agent Country:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrAgentCountry" runat="server"></asp:Literal>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text="Agent Address:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrAgentAddress" runat="server"></asp:Literal>
    <br />
    <br />
    <br />
</asp:Content>
