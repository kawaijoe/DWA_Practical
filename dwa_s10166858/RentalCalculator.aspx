<%@ Page Title="" Language="C#" MasterPageFile="~/StaffTemplate.Master" AutoEventWireup="true" CodeBehind="RentalCalculator.aspx.cs" Inherits="dwa_s10166858.RentalCalculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 200px;
        }
        .auto-style2 {
            width: 200px;
            height: 19px;
        }
        .auto-style3 {
            height: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" class="nav-justified">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style3">Rental Calculator</td>
        </tr>
        <tr>
            <td class="auto-style1">Loan Date</td>
            <td>
                <asp:Calendar ID="calendar" runat="server" Width="242px" OnSelectionChanged="calendar_SelectionChanged"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Number of Books</td>
            <td class="auto-style3">
                <asp:DropDownList ID="ddlNumBooks" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Number of Days</td>
            <td>
                <asp:RadioButtonList ID="rdoNumDays" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rdoNumDays_SelectedIndexChanged"></asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Rental Rate (SGD)</td>
            <td>
                <asp:TextBox ID="txtRentalRate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Due Date</td>
            <td class="auto-style3">
                <asp:Label ID="lblDueDate" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="btnComputeRental" runat="server" Text="Compute Rental" OnClick="btnComputeRental_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Rental Fee (SGD)</td>
            <td class="auto-style3">
                <asp:Label ID="lblRentalFee" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Discount Given (%)</td>
            <td class="auto-style3">
                <asp:Label ID="lblDiscountPercent" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="auto-style2">Amount Payable (SGD)</td>
            <td class="auto-style3">
                <asp:Label ID="lblAmtPayable" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
