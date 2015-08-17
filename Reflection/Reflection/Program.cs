using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("Reflection.Customer");

            Console.WriteLine("Using reflection on " + T.Name + " on namespace " + T.Namespace);

            Console.WriteLine("Properties:");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name + " is " + property.PropertyType + " type.");
            }

            Console.WriteLine("Methods:");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name + " returns " + method.ReturnType + "type.");
            }

            Console.ReadKey();
        }
    }
}
