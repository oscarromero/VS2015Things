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
        public Employee GetEmployee(int Id = 0)
        {
            Employee employee = new Employee();
            string cs = ConfigurationManager.ConnectionStrings["DDBC"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.SqlValue = Id;

                cmd.Parameters.Add(parameterId);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    employee.Id = Convert.ToInt32(reader["Id"]);
                    employee.Name = reader["Name"].ToString();
                    employee.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                }
            }

            return employee;
        }

        public void SetEmployee(Employee employee)
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
                    Value = employee.DateOfBirth.ToShortDateString()
                };

                cmd.Parameters.Add(parameterId);
                cmd.Parameters.Add(parameterName);
                cmd.Parameters.Add(parameterDateOfBirth);

                // 4- Open and Execute
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
