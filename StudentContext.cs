using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace StaffOperatorsApp
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDbConnection") { }

        public DbSet<Student> Students { get; set; }
    }
}