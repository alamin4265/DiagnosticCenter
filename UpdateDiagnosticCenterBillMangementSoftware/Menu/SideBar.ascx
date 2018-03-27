<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SideBar.ascx.cs" Inherits="UpdateDiagnosticCenterBillMangementSoftware.SideBar" %>
<div style="width: 100%">
    <center><h2>OS Diagnostic Center</h2></center>
    <hr />

    <table style="width: 100%; margin-left: 20%;">
        <tr>
            <td>
                <asp:Button ID="typeButton" runat="server" Text="Type Setup" Style="width: 65%; height: 38px; background: cornflowerblue; font-weight: bold" OnClick="typeButton_OnClick" />

            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="testButton" runat="server" Text="Type Setup" Style="width: 65%; height: 38px; background: cornflowerblue; font-weight: bold" /></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="A" runat="server" Text="Test Request Entry" Style="width: 65%; height: 38px; background: cornflowerblue; font-weight: bold" /></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="V" runat="server" Text="Payment" Style="width: 65%; height: 38px; background: cornflowerblue; font-weight: bold" /></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="S" runat="server" Text="Test Wise Report" Style="width: 65%; height: 38px; background: cornflowerblue; font-weight: bold" /></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="j" runat="server" Text="Type Wise Report" Style="width: 65%; height: 38px; background: cornflowerblue; font-weight: bold" /></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="p" runat="server" Text="Unpaid Bill Report" Style="width: 65%; height: 38px; background: cornflowerblue;" /></td>
        </tr>
    </table>

</div>
