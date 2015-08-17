using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDesktopClient
{
    public partial class Form1 : Form
    {
        public List<CustomerService.Customer> Customers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerService.CustomerServiceClient client = new CustomerService.CustomerServiceClient("NetTcpBinding_ICustomerService");
            Customers = client.GetAll(0).ToList();

            foreach(CustomerService.Customer customer in Customers)
            {
                listBox1.Items.Add(customer.Name);
            }
        }
    }
}
