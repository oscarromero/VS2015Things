using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type T = executingAssembly.GetType("LateBinding.Customer");
            object customerInstance = Activator.CreateInstance(T);
      
            MethodInfo method = T.GetMethod("getFullName");            
            String[] parameters = new String[2];
            parameters[0] = "Oscar";
            parameters[1] = "Romero";

            String fullName = (string)method.Invoke(customerInstance, parameters);

            Console.WriteLine(fullName);
            Console.ReadKey();
         }
    }

    class Customer
    {
        public String getFullName(String firstName, String lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
