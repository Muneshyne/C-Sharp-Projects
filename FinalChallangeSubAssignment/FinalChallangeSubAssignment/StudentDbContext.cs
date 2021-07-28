using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalChallangeSubAssignment
{
    public class StudentDbContext :DbContext
    {
        public StudentDbContext(): base()
        {

        }

        public DbSet<Student> Students { get; set; }
    }

    
}
