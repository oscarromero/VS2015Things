<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EmployeeWebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="employeeTable">
            <thead>
                <tr>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        <asp:Label ID="LblEmployeeId" runat="server" Text="Employee Id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtEmployeeID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LblEmployeeName" runat="server" Text="Employee Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtEmployeeName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LblEmployeeDateOfBirth" runat="server" Text="Employee Date of Birth"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtEmployeeDateOfBirth" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnGet" runat="server" Text="Get" OnClick="BtnGet_Click" />
                    </td>
                    <td>
                        <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
                    </td>
                </tr>
            </tbody>
        </table>    
    </div>
    </form>
</body>
</html>
