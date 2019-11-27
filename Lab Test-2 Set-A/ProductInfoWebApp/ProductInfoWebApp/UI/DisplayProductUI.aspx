<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayProductUI.aspx.cs" Inherits="ProductInfoWebApp.UI.DisplayProductUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <legend>Display</legend>
            <div>
            <div>
        <asp:GridView ID="productGridView" runat="server" AutoGenerateColumns="False">
           <Columns>
               <asp:BoundField HeaderText="Code" DataField="ProductCode"/>
               <asp:BoundField HeaderText="Description" DataField="Description"/>
               <asp:BoundField HeaderText="Quantity" DataField="Quantity"/>
           </Columns>
        </asp:GridView>
                <table>
                    <tr><td>
            <asp:Label ID="totalCountLabel" runat="server" Text="Total Count"></asp:Label>                          
                    </td>
                    </tr>
                    <tr>
           <td> <asp:TextBox ID="countTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </div>
        </div>
        </fieldset>
        <a href="IndexUI.aspx">Home</a>
    
    </div>
    </form>
</body>
</html>
