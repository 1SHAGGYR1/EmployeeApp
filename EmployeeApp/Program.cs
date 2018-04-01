using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Greg = new Employee("Greg", 2, 24, 240);
            Greg.DisplayStats();
            Greg.Birthday();
            Greg.DisplayStats();
            Console.ReadKey();
        }
    }
}
