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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(TxtEmployeeID.Text);

            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.Employee employee = client.GetEmployee(employeeId);

            TxtEmployeeName.Text = employee.Name;
            TxtEmployeeDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.Employee employee = new EmployeeService.Employee();

            employee.Id = Convert.ToInt32(TxtEmployeeID.Text);
            employee.Name = TxtEmployeeName.Text.ToString();
            employee.DateOfBirth = Convert.ToDateTime(TxtEmployeeDateOfBirth.Text);

            client.SetEmployee(employee);
        }
    }
}