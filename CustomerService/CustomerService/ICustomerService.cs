using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CustomerService
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        List<Customer> GetAll(int Id = 0);
    }
}
