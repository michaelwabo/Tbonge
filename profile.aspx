<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Practice_makes_perfect.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label3" runat="server" Text="First Name :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrFirstName" runat="server"></asp:Literal>
    <br />
    <br />
    Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrLastName" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Phone Number: "></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrPhone" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Location: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrLocation" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Occupation: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrOccupation" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="DoB: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrDOB" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="Account Balance:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrBalance" runat="server"></asp:Literal>

    <br />
    <br />
    <asp:Label ID="Label9" runat="server" Text="Savings"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrSavings" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:Label ID="Label10" runat="server" Text="Loan Limit:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Literal ID="ltrLoanLimit" runat="server"></asp:Literal>
&nbsp;&nbsp;
    <asp:Label ID="Label11" runat="server" Text="Loan Balance:"></asp:Label>
&nbsp;&nbsp;
    <asp:Literal ID="ltrLoanBalance" runat="server"></asp:Literal>
    <br />
    <br />

</asp:Content>
