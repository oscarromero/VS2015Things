<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompanyClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border:1px solid">
            <thead>
                <tr>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        <asp:Button ID="PublicButton" runat="server" Text="GetPublicInformation" Width="300px" OnClick="PublicButton_Click" />
                    </td>
                    <td>
                        <asp:Label ID="PublicLabel" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ConfidentialButton" runat="server" Text="GetConfidentialInformation" Width="300px" OnClick="ConfidentialButton_Click" />
                    </td>
                    <td>
                        <asp:Label ID="ConfidentialLabel" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    </form>
</body>
</html>
