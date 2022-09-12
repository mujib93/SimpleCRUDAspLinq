<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="AspLinq.UsersList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="padding:15px">
        <table class="nav-justified">
            <tr>
                <td align="center" colspan="2" style="font-family: Arial; font-size: x-large; background-color: #808080; color: #FFFFFF; font-weight: bold; bottom: 15px;">FORM USERS</td>
            </tr>
            <tr>
                <td style="width: 218px" class="modal-sm">
                    <br />
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Text="UserID"></asp:Label>
                    <br />
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="UserId_log" runat="server" Font-Bold="True" Font-Size="Medium" Width="234px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 218px; height: 20px">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Username"></asp:Label>
                    <br />
                </td>
                <td style="height: 20px">
                    <asp:TextBox ID="Username_log" runat="server" Font-Bold="True" Font-Size="Medium" Width="234px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 218px" class="modal-sm">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="Password"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="Password_log" runat="server" Font-Bold="True" Font-Size="Medium" Width="234px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 218px" class="modal-sm">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" Text="Name"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="Name_log" runat="server" Font-Bold="True" Font-Size="Medium" Width="234px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 218px" class="modal-sm">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" Text="Address"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="Address_log" runat="server" Font-Bold="True" Font-Size="Medium" Width="234px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 218px" class="modal-sm">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" Text="Email"></asp:Label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="Email_log" runat="server" Font-Bold="True" Font-Size="Medium" Width="234px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 218px" class="modal-sm">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 218px" class="modal-sm">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Text="Submit" OnClick="Button1_Click" />
                &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Update" OnClick="Button_Update" />
                &nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Font-Bold="True" Text="Delete" OnClick="Button_Delete" OnClientClick= "return confirm('Are You Sure To delete ?');" />
                &nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" Font-Bold="True" Text="Export Excel" OnClick="Button_ExportExcel" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" Font-Bold="True" Height="142px" style="margin-top: 22px" Width="710px">
            <PagerStyle BackColor="#666666" ForeColor="#CCCCCC" />
        </asp:GridView>
    </div>
</asp:Content>
