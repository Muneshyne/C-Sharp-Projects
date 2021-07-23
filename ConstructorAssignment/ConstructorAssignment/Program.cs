using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a const variable
            const string place = "Cosmo's Wonderland";
            Console.WriteLine(place);

            // create a variable using the keyword "var"
            var attractions = new Dictionary<string, int>() { ["Cosmic Wheel"] = 4, ["Space Jam"] = 8 };
            Console.WriteLine(attractions["Cosmic Wheel"]);

            Ride ride = new Ride("Space Jam", 8, 48);
            Ride newRide = new Ride();

            Console.WriteLine(ride.Height);
            Console.WriteLine(newRide.Height);
            Console.ReadLine();
        }
    }
}
