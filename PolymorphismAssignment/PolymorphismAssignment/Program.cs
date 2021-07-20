using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee();
            employee.Quit();
            Console.Read();
        }
    }
}
