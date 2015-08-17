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
                        <asp:Label ID="LblEmployeeType" runat="server" Text="Employee Type"></asp:Label>

                    </td>
                    <td>
                        <asp:DropDownList ID="CbxEmployeeType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CbxEmployeeType_SelectedIndexChanged">
                            <asp:ListItem Text="Select Employee Type" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="Full Time Employee" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Part Time Employee" Value="2"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr id="trAnnualSalary" runat="server" visible="false">
                    <td>
                        <asp:Label ID="LblAnnualSalary" runat="server" Text="Annual Salary"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtAnnualSalary" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr id="trHourlyPay" runat="server" visible="false">
                    <td>
                        <asp:Label ID="LblHourlyPay" runat="server" Text="Hourly Pay"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtHourlyPay" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr id="trHoursWorked" runat="server" visible="false">
                    <td>
                        <asp:Label ID="LblHoursWorked" runat="server" Text="Hours Worked"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtHoursWorked" runat="server"></asp:TextBox>
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
