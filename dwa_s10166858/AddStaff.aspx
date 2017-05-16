<%@ Page Title="" Language="C#" MasterPageFile="~/StaffTemplate.Master" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="dwa_s10166858.AddStaff" %>
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
            <td class="auto-style1">&nbsp;</td>
            <td><b>Add Staff Record</b></td>
        </tr>
        <tr>
            <td class="auto-style1">Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Please specify a name"
                    Display="Dynamic" ControlToValidate="txtName" CssClass="alert-danger"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Gender</td>
            <td>
                <asp:RadioButton ID="radMale" runat="server" GroupName="Gender" Text="Male" Checked="True" />
                <asp:RadioButton ID="radFemale" runat="server" GroupName="Gender" Text="Female" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">DOB (dd-mm-yyyy)</td>
            <td>
                <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Salary</td>
            <td>
                <asp:TextBox ID="txtSalary" runat="server" ControlToValidate="txtSalary"></asp:TextBox>
                <asp:CompareValidator ID="covSalary" runat="server" Operator="DataTypeCheck"
                    ErrorMessage="Please specify a valid salary" Display="Dynamic" Type="Currency"
                    ControlToValidate="txtSalary" CssClass="alert-danger"></asp:CompareValidator>
                <asp:RangeValidator ID="ravSalary" runat="server" ErrorMessage="Please specify between 1 to 10000"
                    ControlToValidate="txtSalary" MaximumValue="10000" MinimumValue="1" Type="Currency" CssClass="alert-danger"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="Please specify a valid email"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail"
                    Display="Dynamic" CssClass="alert-danger"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Nationality</td>
            <td>
                <asp:DropDownList ID="ddlNationality" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:CheckBox ID="chkFullTime" runat="server" Text="Full-Time Staff"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
                <asp:Label ID="lblValues" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
