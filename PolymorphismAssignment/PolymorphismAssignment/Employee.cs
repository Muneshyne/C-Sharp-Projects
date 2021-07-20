using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : IQuittable
    {
        //// Implement the SayName() method inside of the Employee class
        //public override void SayName()
        //{
        //    Console.WriteLine("Name: {0} {1}", firstName, lastName); //instantiate
        //}
        // have you employee class from the previous drill inherit that interface and implement the Quit() method
        public void Quit()
        {
            Console.WriteLine("Quit() method.");
        }
    }
}
