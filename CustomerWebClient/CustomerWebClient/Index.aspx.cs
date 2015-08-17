using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerWebClient
{
    public partial class Index : System.Web.UI.Page
    {
        public List<CustomerService.Customer> Customers;

        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerService.CustomerServiceClient customerClient = new CustomerService.CustomerServiceClient("BasicHttpBinding_ICustomerService");
            Customers = customerClient.GetAll(0).ToList();

            //LinqDataSource DataSource = new LinqDataSource();
            //DataSource.ID = "LinqCustomers";
            //DataSource.ContextTypeName = "CustomerWebClient.Index";
            //DataSource.Select = "new(Id, Name, Email)";
            //DataSource.TableName = "Customers";
            //Controls.Add(DataSource);
            //GridView1.DataSourceID = "LinqCustomers";

            foreach(CustomerService.Customer customer in Customers)
            {
                Response.Write("<p>" + customer.Name + "</p>");
            }
        }
    }
}