using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of 10 employees, each with a firstName, lastName and Id. 
            // at least two employees should be named "Joe."
            Employee emp0 = new Employee() { firstName = "Freddie", lastName = "Mercury", Id = 0 };
            Employee emp1 = new Employee() { firstName = "Nikki", lastName = "Sixx", Id = 1 };
            Employee emp2 = new Employee() { firstName = "Lars", lastName = "Ulrich", Id = 2 };
            Employee emp3 = new Employee() { firstName = "Kirk", lastName = "Hammet", Id = 3 };
            Employee emp4 = new Employee() { firstName = "Joe", lastName = "Hetfield", Id = 4 };
            Employee emp5 = new Employee() { firstName = "Chester", lastName = "Bennington", Id = 5 };
            Employee emp6 = new Employee() { firstName = "Axl", lastName = "Rose", Id = 6 };
            Employee emp7 = new Employee() { firstName = "Serj", lastName = "Tankian", Id = 7 };
            Employee emp8 = new Employee() { firstName = "Joe", lastName = "Shmoe", Id = 8 };
            Employee emp9 = new Employee() { firstName = "Joe", lastName = "Ozbourne", Id = 9 };

            List<Employee> employees = new List<Employee>()
            {
                emp0, emp1,emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9,
            };

            // using a foreach loop, create a newList of all employees with the firstName "Joe"
            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    newList.Add(employee);
                }
            }
            // using a lambda expression, create a new list of all employees with the first name "Joe".
            List<Employee> firstNameJoe = employees.Where(x => x.firstName == "Joe").ToList();

            // using a lambda expression, create a new list of all employees with an Id greater than 5. 
            List<Employee> idGreaterThan5 = employees.Where(x => x.Id > 5).ToList(); 
            // and four with an Id > 5.
            Console.WriteLine(newList.Count());
            Console.WriteLine(firstNameJoe.Count());
            Console.WriteLine(idGreaterThan5.Count());
            Console.ReadLine();
        }
    }
}
