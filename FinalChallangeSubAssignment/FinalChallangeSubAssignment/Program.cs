using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallangeSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentDbContext())
            {
                var student = new Student()
                {
                    StudentName = "Jar Jar Binx",
                    EmailAddress = "jarjar1@gmail.com",
                    DateOfBirth = DateTime.Now
                };

                db.Students.Add(student);
                db.SaveChanges();

                var query = from listed in db.Students
                            select listed;

                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }

                Console.ReadLine();
            }
        }
    }
}
