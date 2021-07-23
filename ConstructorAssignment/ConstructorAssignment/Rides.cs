using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Ride
    {
        //chain two constructors together
        public Ride() :this(null, 0, 0)
        {
        }
        // info on ride
        public Ride(string type, int numOfSeats, int heightReq)
            {
                Type = type;
                Seats = numOfSeats;
                Height = heightReq;
            }
            public string Type { get; set; }
            public int Seats { get; set; }
            public int Height { get; set; }
    }
}
