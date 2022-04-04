<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="Practice_makes_perfect.history" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    <asp:Label ID="Label3" runat="server" Text="Below is the transaction history for you account." ForeColor="Green"></asp:Label>
    <br />
    <br />
    <asp:Table ID="Table1" runat="server" Width="467px" GridLines="Horizontal" CellPadding="2" CellSpacing="2">
        <asp:TableRow runat="server">
        </asp:TableRow>
        <asp:TableRow runat="server">
        </asp:TableRow>
        <asp:TableRow runat="server">
        </asp:TableRow>
        <asp:TableRow runat="server">
        </asp:TableRow>
        <asp:TableRow runat="server">
        </asp:TableRow>
        <asp:TableRow runat="server">
        </asp:TableRow>
        <asp:TableRow runat="server">
        </asp:TableRow>
        <asp:TableRow runat="server" HorizontalAlign="Justify" VerticalAlign="Middle">
        </asp:TableRow>
        <asp:TableRow runat="server">
        </asp:TableRow>
        <asp:TableRow runat="server">
        </asp:TableRow>
    </asp:Table>
    
</asp:Content>
