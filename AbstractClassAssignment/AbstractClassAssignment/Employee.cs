﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person
    {
        // Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName); //instantiate
        }
    }
}
