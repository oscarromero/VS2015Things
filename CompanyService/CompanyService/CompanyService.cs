using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService
    {
        public string GetPublicInformation()
        {
            return "Public Information";
        }

        public string GetConfidentialInformation()
        {
            return "Confidential Information";
        }
    }
}
