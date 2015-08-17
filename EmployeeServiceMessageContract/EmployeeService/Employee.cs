using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.ServiceModel;

namespace EmployeeService
{
    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }

    [MessageContract(IsWrapped =true, WrapperName ="EmployeeRequestObject", WrapperNamespace ="http://mycompany.com/Employee")]
    public class EmployeeRequest
    {
        [MessageHeader(Namespace ="http://mycompany.com/Employee")]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Name ="EmployeeId", Namespace ="http://mycompany.com/Employee")]
        public int EmployeeId { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeInfoObject", WrapperNamespace = "http://mycompany.com/Employee")]
    public class EmployeeInfo
    {
        [MessageBodyMember(Order =1, Namespace = "http://mycompany.com/Employee")]
        public int Id { get; set; }

        [MessageBodyMember(Order = 2, Namespace = "http://mycompany.com/Employee")]
        public string Name { get; set; }

        [MessageBodyMember(Order = 3, Namespace = "http://mycompany.com/Employee")]
        public DateTime DOB { get; set; }

        [MessageBodyMember(Order = 4, Namespace = "http://mycompany.com/Employee")]
        public EmployeeType Type { get; set; }

        [MessageBodyMember(Order = 5, Namespace = "http://mycompany.com/Employee")]
        public int AnnualSalary { get; set; }

        [MessageBodyMember(Order = 6, Namespace = "http://mycompany.com/Employee")]
        public int HourlyPay { get; set; }

        [MessageBodyMember(Order = 7, Namespace = "http://mycompany.com/Employee")]
        public int HoursWorked { get; set; }

        public EmployeeInfo()
        {

        }

        public EmployeeInfo(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            DOB = employee.DateOfBirth;
            Type = employee.Type;
            if (Type == EmployeeType.FullTimeEmployee)
            {
                AnnualSalary = ((FullTimeEmployee)employee).AnnualSalary;
            }
            else
            {
                HourlyPay = ((PartTimeEmployee)employee).HourlyPay;
                HoursWorked = ((PartTimeEmployee)employee).HoursWorked;
            }
        }
    }

    //[Serializable] // Expose the private name fields
    //[DataContract] // If you want to expose some fields and customize
    //[DataContract(Namespace = "http://mynamespace.com/Employee")]
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    public class Employee
    {
        private int _Id;
        private string _Name;
        private DateTime _DateOfBirth;

        public EmployeeType Type { get; set; }

        //[DataMember] // Expose these field
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        // [DataMember] // Expose these field
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
    }
}
