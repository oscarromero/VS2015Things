using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["appConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand sql = new SqlCommand("SELECT * FROM SalesLT.Customer", con);

            List<CustomerClass> customers = new List<CustomerClass>();

            con.Open();
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                CustomerClass customer = new CustomerClass();
                customer.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                customer.FullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                customer.Phone = reader["Phone"].ToString();

                customers.Add(customer);
            }
            con.Close();

            GridView1.DataSource = customers;
            GridView1.DataBind();
        }
    }

    public class CustomerClass
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
    }
}