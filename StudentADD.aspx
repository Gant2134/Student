<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentADD.aspx.cs" Inherits="StudentADD" MasterPageFile="~/SiteMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" Runat="Server">
    <p>
    <asp:Label ID="titlelbl" runat="server" Text="Manage students"></asp:Label>
    <br />
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Student ID"></asp:Label>
&nbsp;
    <asp:TextBox ID="Input1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
&nbsp;
    <asp:TextBox ID="Input2" runat="server"></asp:TextBox>
&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
&nbsp;
    <asp:TextBox ID="input3" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label4" runat="server" Text="Phone Number"></asp:Label>
&nbsp;
    <asp:TextBox ID="input4" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
&nbsp;<asp:TextBox ID="input5" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label6" runat="server" Text="Gpa"></asp:Label>
&nbsp;<asp:TextBox ID="input6" runat="server"></asp:TextBox>
</p>
<p style="margin-left: 640px">
    <asp:Button ID="Updatebtn" runat="server" OnClick="Updatebtn_Click" Text="Update" />
</p>
<p>
    &nbsp;</p>
</asp:Content>