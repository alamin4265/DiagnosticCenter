<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TypeSetup.aspx.cs" Inherits="UpdateDiagnosticCenterBillMangementSoftware.UI.TypeSetup" %>

<%@ Register Src="~/Menu/SideBar.ascx" TagPrefix="uc1" TagName="SideBar" %>
<%@ Register Src="~/Menu/HeaderBar.ascx" TagPrefix="uc1" TagName="HeaderBar" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>OS Diagnostic Center</title>
    <%-- <link href="../Content/bootstrap.min.css" rel="stylesheet" />--%>
</head>
<body>

    <form id="form1" runat="server">
        <div style="width: 100%;margin-bottom: 20px" >
            <center><uc1:HeaderBar runat="server" id="HeaderBar" /></center>
        </div>
        <div>
            <div style="width: 30%;float: left">
                <uc1:SideBar runat="server" id="SideBar" />
            </div>


            <div style="width: 70%;float: left">
                <table style="width: 80%" align="center">
                    <tr>
                        <td>
                            <fieldset>
                                <legend>
                                    <h3>Test Type Setup</h3>
                                </legend>
                                <table style="width: 100%">
                                    <tr>
                                        <td>
                                            <fieldset>
                                                <legend>&nbsp&nbsp&nbsp&nbsp&nbsp</legend>
                                                <center>
                                            <table>
                                            <tr>
                                                <td><label>Type Name</label></td>
                                                <td>
                                                    <asp:TextBox  ID="typeNameTb" ValidationGroup="typeGroup" style="width:250px;font-size:20px" runat="server"></asp:TextBox>
                                                </td>   
                                                <asp:RequiredFieldValidator ValidationGroup="typeGroup" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Required" ForeColor="red" ControlToValidate="typeNameTb"></asp:RequiredFieldValidator>
                                            </tr>  
                                                <tr>
                                                <td></td>
                                                <td>
                                                    <asp:Label ID="messageLabel" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td></td>
                                                <td><asp:Button style="float:right" ValidationGroup="typeGroup" ID="saveButton" runat="server" font-size="15px" Text="Save" OnClick="saveButton_Click"/></td>
                                            </tr>
                                            </table>
                                            </center>
                                            </fieldset>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <asp:GridView Style="text-align: center; margin-top: 20px" ID="showGridView" runat="server" EmptyDataText="No Data Found" AutoGenerateColumns="False" BorderWidth="1px" CellPadding="3" Width="100%">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="SL">
                                                        <ItemTemplate><%#Container.DataItemIndex + 1 %></ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Type Name">
                                                        <ItemTemplate><%#Eval("Name")%></ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                            </fieldset>
                        </td>
                    </tr>

                </table>
            </div>

        </div>



        <%--        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:Timer runat="server" id="UpdateTimer" interval="1000" ontick="UpdateTimer_Tick" />
        <asp:UpdatePanel runat="server" id="TimedPanel" updatemode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger controlid="UpdateTimer" eventname="Tick" />
            </Triggers>
            <ContentTemplate>
                <asp:Label runat="server" id="DateStampLabel" />
            </ContentTemplate>
        </asp:UpdatePanel>--%>
    </form>

</body>
</html>
