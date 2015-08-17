using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CustomerService
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetAll(int Id = 0)
        {
            List<Customer> customers = new List<Customer>();

            string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IdParamater = new SqlParameter()
                {
                    ParameterName = "@Id",
                    SqlDbType = SqlDbType.Int,
                    SqlValue = Id
                };

                cmd.Parameters.Add(IdParamater);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    customers.Add(new Customer()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString()
                    });
                }
            }

            return customers;
        }
    }
}
