using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace EmployeeService
{
    //[Serializable] // Expose the fields
    //[DataContract]
    public class Employee
    {
        private int _Id;
        private string _Name;
        private DateTime _DateOfBirth;

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
