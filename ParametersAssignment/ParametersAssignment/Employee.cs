using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // make the employee class take a generic type parameter
    public class Employee<T>
    {
        // add a property to the Employee class called "things" and have its data type
        // be a generic list matching the generic type of class.
        public List<T> Strings { get; set; }
    }
    
}
