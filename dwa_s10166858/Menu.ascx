<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="dwa_s10166858.Menu" %>

<nav class="navbar navbar-default">
    <div> <!-- navbar wrapper -->
        <div class="navbar-header">
            <!-- Navbar to be displayed as a hamburger button when collapsed -->
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#StaffNavbar">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <!-- The brand(or icon) of the navbar, will always be displayed -->
            <a class="navbar-brand" href="Menu.aspx" style="font-size:36px; font-weight:bold; color:#3399FF">
                NP Book Rental
            </a>
        </div>
        <div class="collapse navbar-collapse" id="staffNavbar">
            <!-- Links in the navbar -->
            <!-- will be displayefd as drop-down list when collapsed -->
            <ul class="nav navbar-nav">
                <li><a href="AddStaff.aspx">Add Staff</a></li>
                <li><a href="ViewStaff.aspx">View Staff</a></li>
                <li><a href="ViewBranch.aspx">View Branch</a></li>
                <li><a href="RentalCalculator.aspx">Rental Calculator</a></li>
                <li><a href="FineCalculator.aspx">Fine Calculator</a></li>
            </ul>
            <!-- A Web Form Control button for logging out user -->
            <asp:Button ID="btnLogOut" runat="server" Text="Log Out" CssClass="btn btn-link navbar-btn navbar-right" />
        </div>
    </div>
</nav>