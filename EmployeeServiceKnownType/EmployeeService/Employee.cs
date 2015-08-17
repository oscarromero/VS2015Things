using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace EmployeeService
{
    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
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
