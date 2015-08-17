using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        //public Employee GetEmployee(int Id = 0)
        public EmployeeInfo GetEmployee(EmployeeRequest request)
        {
            Employee employee = null;//new Employee();
            string cs = ConfigurationManager.ConnectionStrings["DDBC"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.SqlValue = request.EmployeeId;//Id;

                cmd.Parameters.Add(parameterId);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    if((EmployeeType)reader["EmployeeType"] == EmployeeType.FullTimeEmployee)
                    {
                        employee = new FullTimeEmployee
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            Type = EmployeeType.FullTimeEmployee,
                            AnnualSalary = Convert.ToInt32(reader["AnnualSalary"])
                        };
                    }
                    else
                    {
                        employee = new PartTimeEmployee
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            Type = EmployeeType.PartTimeEmployee,
                            HourlyPay = Convert.ToInt32(reader["HourlyPay"]),
                            HoursWorked = Convert.ToInt32(reader["HoursWorked"])
                        };
                    }
                }
            }

            //return employee;
            return new EmployeeInfo(employee);
        }

        //public void SetEmployee(Employee employee)
        public void SetEmployee(EmployeeInfo employee)
        {
            // 1- Parepare the connection
            string cs = ConfigurationManager.ConnectionStrings["DDBC"].ConnectionString;
            using(SqlConnection conn = new SqlConnection(cs))
            {
                // 2- Setup the command type
                SqlCommand cmd = new SqlCommand("spSaveEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // 3- Add the parameters
                SqlParameter parameterId = new SqlParameter()
                {
                    ParameterName = "@Id",
                    Value = employee.Id
                };

                SqlParameter parameterName = new SqlParameter()
                {
                    ParameterName = "@Name",
                    Value = employee.Name
                };

                SqlParameter parameterDateOfBirth = new SqlParameter()
                {
                    ParameterName = "@DateOfBirth",
                    Value = employee.DOB.ToShortDateString() //employee.DateOfBirth.ToShortDateString()
                };

                SqlParameter parameterEmployeeType = new SqlParameter()
                {
                    ParameterName = "@EmployeeType",
                    Value = employee.Type
                };

                cmd.Parameters.Add(parameterId);
                cmd.Parameters.Add(parameterName);
                cmd.Parameters.Add(parameterDateOfBirth);
                cmd.Parameters.Add(parameterEmployeeType);

                //if (employee.GetType() == typeof(FullTimeEmployee))
                if(employee.Type == EmployeeType.FullTimeEmployee)
                {
                    SqlParameter parameterAnnualSalary = new SqlParameter()
                    {
                        ParameterName = "@AnnualSalary",
                        Value = employee.AnnualSalary //((FullTimeEmployee)employee).AnnualSalary
                    };

                    cmd.Parameters.Add(parameterAnnualSalary);
                }
                else
                {
                    SqlParameter parameterHourlyPay = new SqlParameter()
                    {
                        ParameterName = "@HourlyPay",
                        Value = employee.HourlyPay //((PartTimeEmployee)employee).HourlyPay
                    };

                    SqlParameter parameterHoursWorked = new SqlParameter()
                    {
                        ParameterName = "@HoursWorked",
                        Value = employee.HoursWorked //((PartTimeEmployee)employee).HoursWorked
                    };

                    cmd.Parameters.Add(parameterHourlyPay);
                    cmd.Parameters.Add(parameterHoursWorked);
                }

                // 4- Open and Execute
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
