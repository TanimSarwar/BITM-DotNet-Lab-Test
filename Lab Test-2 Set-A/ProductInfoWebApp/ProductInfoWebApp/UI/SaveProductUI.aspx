<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaveProductUI.aspx.cs" Inherits="ProductInfoWebApp.UI.SaveProductUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <legend>
                Save
            </legend>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Product Code"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="productCodeTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="descriptionTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="quantityTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                     <td>
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />&nbsp;<asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" />
                     </td>
                    
                </tr>
                <tr>
                    <td><a href="IndexUI.aspx">Home</a></td>
                </tr>
            </table>
        </fieldset>
        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
