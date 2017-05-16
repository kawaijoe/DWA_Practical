<%@ Page Title="" Language="C#" MasterPageFile="~/StaffTemplate.Master" AutoEventWireup="true" CodeBehind="FineCalculator.aspx.cs" Inherits="dwa_s10166858.FineCalculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" class="nav-justified">
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style3">Fine Calculator</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td rowspan="7">
                <asp:Calendar ID="calDueDate" runat="server" OnSelectionChanged="CalDueDate_SelectionChanged" CssClass="auto-style5" Width="235px"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Due Date:</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lblDueDate" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Number of days overdue:</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lblDayOverdue" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Fine Rate (SGD):</td>
            <td class="auto-style6">&nbsp;<asp:Label ID="lblFineRate" runat="server" Text=""></asp:Label>
                (per book per day)</td>
        </tr>
        <tr>
            <td class="auto-style1">Number of books overdue:</td>
            <td>
                <asp:TextBox ID="txtNumOverdueBK" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btnCompute" runat="server" OnClick="btnCompute_Click" Text="Compute" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Fine (SGD):</td>
            <td class="auto-style6">
                <asp:Label ID="lblFine" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Breakdown of the fine:</td>
            <td rowspan="3">
                <asp:Label ID="lblFineBreakdown" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:RequiredFieldValidator ID="Error1" runat="server" Display="Dynamic" ErrorMessage="Number of overdue books(s) field is mandatory" ControlToValidate="txtNumOverdueBK" CssClass="alert-danger"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="Error2" runat="server" Display="Dynamic" ErrorMessage="Number of overdue book(s) field should be between 1 to 10" ControlToValidate="txtNumOverdueBK"
                    MaximumValue="10" MinimumValue="1" Type="Integer" CssClass="alert-danger"></asp:RangeValidator>
            </td>
        </tr>
    </table>
</asp:Content>
