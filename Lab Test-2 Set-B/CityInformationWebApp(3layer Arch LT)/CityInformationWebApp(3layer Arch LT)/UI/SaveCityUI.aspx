<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaveCityUI.aspx.cs" Inherits="CityInformationWebApp_3layer_Arch_LT_.UI.SaveCityUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <legend>City Information</legend>
            <div align="center">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="City Name"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="cityNameTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="About"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="aboutTextBox" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Country"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="countryTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td></td>
                        <td style="text-align: right">
                            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" /></td>
                                    

                     </tr>

                    <tr>
                        <td></td>
                        <td style="text-align: right"><asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click"/></td>
                    </tr>   
                </table>
            </div>
        </fieldset>
        <div style="text-align: center">
        <asp:Label runat="server" ID="messageLabel" Text=""></asp:Label><br/>
        <a href="IndexUI.aspx" style="text-decoration: none" > Home </a>
            <a href="SearchCityUI.aspx" style="text-decoration: none"> Search</a>
            </div>
    </div>
    </form>
</body>
</html>
