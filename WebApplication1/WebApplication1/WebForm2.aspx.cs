using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();

            GridView1.DataSource = from customer in dataContext.Customers
                                   where customer.Title == "Mr."
                                   select customer;
            GridView1.DataBind();

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            object x = from number in numbers where (number % 2) == 0 select number;
        }
    }
}