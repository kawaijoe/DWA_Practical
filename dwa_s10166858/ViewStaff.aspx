<%@ Page Title="" Language="C#" MasterPageFile="~/StaffTemplate.Master" AutoEventWireup="true" CodeBehind="ViewStaff.aspx.cs" Inherits="dwa_s10166858.ViewStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    View Staff
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    <asp:GridView ID="gvStaff" runat="server" AllowPaging="True" OnPageIndexChanging="gvStaff_PageIndexChanging" PageSize="5">
    </asp:GridView>
</asp:Content>
