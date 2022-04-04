<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Practice_makes_perfect.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label3" runat="server" Text="Fill the form below to register for  Tbonge"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Name: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtName" runat="server" Width="169px" CssClass="textbox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Enter Name:" ForeColor="Red" ValidationGroup="vg">*</asp:RequiredFieldValidator>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Phone Number:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPhone" runat="server" Width="170px" TextMode="Phone" CssClass="textbox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPhone" ErrorMessage="Enter phone" ForeColor="Red" ValidationGroup="vg">*</asp:RequiredFieldValidator>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Email:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtEmail" runat="server" Width="177px" TextMode="Email" CssClass="textbox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Email" ForeColor="Red" ValidationGroup="vg">*</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email Address" ForeColor="Red">*</asp:RegularExpressionValidator>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Password: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPassword" runat="server" Width="175px" TextMode="Password" CssClass="textbox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword" ErrorMessage="Enter Password" ForeColor="Red" ValidationGroup="vg">*</asp:RequiredFieldValidator>
<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirm" ErrorMessage="Password and repeat password do not match" ForeColor="Red" ValidationGroup="vg">*</asp:CompareValidator>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text="Repeat password:"></asp:Label>
&nbsp;<asp:TextBox ID="txtConfirm" runat="server" Width="160px" TextMode="Password" CssClass="textbox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtConfirm" ErrorMessage="Enter Repeat Password" ForeColor="Red" ValidationGroup="vg">*</asp:RequiredFieldValidator>
<br />
<br />
&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" BackColor="Black" ForeColor="Gold" OnClick="Button1_Click" Text="Register" Width="216px" CssClass="button" />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="login.aspx">Login</asp:HyperLink>
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Fix these erros before you proceed" ValidationGroup="vg" />
    <br />
    <br />
    <br />
</asp:Content>
