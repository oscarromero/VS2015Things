using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private CompanyService.CompanyPublicServiceClient companyPublicService;
        private CompanyService.CompanyConfidentialServiceClient companyConfidentialService;

        protected void Page_Load(object sender, EventArgs e)
        {
            companyPublicService = new CompanyService.CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
            companyConfidentialService = new CompanyService.CompanyConfidentialServiceClient("NetTcpBinding_ICompanyConfidentialService");
        }

        protected void PublicButton_Click(object sender, EventArgs e)
        {
            PublicLabel.Text = companyPublicService.GetPublicInformation();
        }

        protected void ConfidentialButton_Click(object sender, EventArgs e)
        {
            ConfidentialLabel.Text = companyConfidentialService.GetConfidentialInformation();
        }
    }
}