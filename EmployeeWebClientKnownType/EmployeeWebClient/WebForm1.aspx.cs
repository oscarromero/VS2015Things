using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private void hideWhenEmployeeType()
        {
            trAnnualSalary.Visible = false;
            trHourlyPay.Visible = false;
            trHoursWorked.Visible = false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(TxtEmployeeID.Text);

            //EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            //EmployeeService.Employee employee = client.GetEmployee(employeeId);
            EmployeeService.IEmployeeService client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.EmployeeRequest request = new EmployeeService.EmployeeRequest("QWERTY", Convert.ToInt32(TxtEmployeeID.Text));
            EmployeeService.EmployeeInfo employee = client.GetEmployee(request);


            TxtEmployeeName.Text = employee.Name;
            //TxtEmployeeDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            TxtEmployeeDateOfBirth.Text = employee.DOB.ToShortDateString();

            // Show the employee type data
            hideWhenEmployeeType();
            if (employee.Type == EmployeeService.EmployeeType.FullTimeEmployee)
            {
                trAnnualSalary.Visible = true;
                TxtAnnualSalary.Text = employee.AnnualSalary.ToString(); //((EmployeeService.FullTimeEmployee)employee).AnnualSalary.ToString();
            }
            else
            {
                trHourlyPay.Visible = true;
                trHoursWorked.Visible = true;
                TxtHourlyPay.Text = employee.HourlyPay.ToString(); //((EmployeeService.PartTimeEmployee)employee).HourlyPay.ToString();
                TxtHoursWorked.Text = employee.HoursWorked.ToString(); //((EmployeeService.PartTimeEmployee)employee).HoursWorked.ToString();
            }

            CbxEmployeeType.SelectedValue = ((int)employee.Type).ToString();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            //EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.IEmployeeService client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.EmployeeInfo employee = new EmployeeService.EmployeeInfo();

            int _Id = Convert.ToInt32(TxtEmployeeID.Text);
            DateTime _DateOfBirth = Convert.ToDateTime(TxtEmployeeDateOfBirth.Text.ToString());
            EmployeeService.EmployeeType _Type = ((EmployeeService.EmployeeType)Convert.ToInt32(CbxEmployeeType.SelectedValue.ToString()));

            if (((EmployeeService.EmployeeType)(Convert.ToInt32(CbxEmployeeType.SelectedValue))) == EmployeeService.EmployeeType.FullTimeEmployee)
            {
                employee.AnnualSalary = Convert.ToInt32(TxtAnnualSalary.Text.ToString());
            }
            else if(((EmployeeService.EmployeeType)Convert.ToInt32(CbxEmployeeType.SelectedValue)) == EmployeeService.EmployeeType.PartTimeEmployee)
            {
                employee.HourlyPay = Convert.ToInt32(TxtHourlyPay.Text);
                employee.HoursWorked = Convert.ToInt32(TxtHoursWorked.Text);
            }
            else
            {

            }

            employee.Id = _Id;
            employee.Name = TxtEmployeeName.Text.ToString();
            employee.DOB = _DateOfBirth;
            employee.Type = _Type;

            client.SetEmployee(employee);
        }

        protected void CbxEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxEmployeeType.SelectedValue == "-1")
            {
                hideWhenEmployeeType();
            }
            else if (CbxEmployeeType.SelectedValue == "1")
            {
                hideWhenEmployeeType();
                trAnnualSalary.Visible = true;
            }
            else
            {
                hideWhenEmployeeType();
                trHourlyPay.Visible = true;
                trHoursWorked.Visible = true;
            }
        }
    }
}