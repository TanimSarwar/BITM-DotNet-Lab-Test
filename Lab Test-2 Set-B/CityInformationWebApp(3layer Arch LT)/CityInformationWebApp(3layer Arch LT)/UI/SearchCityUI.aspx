<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCityUI.aspx.cs" Inherits="CityInformationWebApp_3layer_Arch_LT_.UI.SearchCityUI" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Search</legend>
        <div>
        <table>
            <tr>
                <td>
            <asp:RadioButton GroupName="searchRadioButton" ID="searchByCityRadioButton" runat="server" Text="Search by City" /> 
                    
                </td>
                <td>
                    <asp:TextBox ID="searchTextBox" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" /></td>
       <td>
            <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" />
            </td>
            </tr>
            <tr>
                <td>
            <asp:RadioButton GroupName="searchRadioButton" ID="searchByCountryRadioButton" runat="server" Text="Search by Country" />      
            </td>
            </tr>
        </table>
            </div>
        <div align="center">
        <asp:GridView ID="cityGridView" runat="server" AutoGenerateColumns="False">
           <Columns>
              <asp:TemplateField HeaderText="Serial No.">
                  <ItemTemplate>
                      <%#Container.DataItemIndex+1%>
                  </ItemTemplate>
              </asp:TemplateField>
               <asp:BoundField HeaderText="City Name" DataField="Name"/>
               <asp:BoundField HeaderText="About" DataField="About"/>
               <asp:BoundField HeaderText="Country" DataField="Country"/>
           </Columns>
        </asp:GridView>
            </div>
    </fieldset>
    </div>
        <div style="text-align: center">
        <asp:Label runat="server" ID="messageLabel" Text=""></asp:Label><br/>
        <a href="IndexUI.aspx" style="text-decoration: none" > Home </a>
        <a href="SaveCityUI.aspx" style="text-decoration: none" > Save </a>
            </div>
    </form>
</body>
</html>
