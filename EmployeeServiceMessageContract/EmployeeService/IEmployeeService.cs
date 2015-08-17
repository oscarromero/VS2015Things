using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        //Employee GetEmployee(int Id);
        EmployeeInfo GetEmployee(EmployeeRequest request);

        [OperationContract]
        //void SetEmployee(Employee employee);
        void SetEmployee(EmployeeInfo employee);
    }
}
