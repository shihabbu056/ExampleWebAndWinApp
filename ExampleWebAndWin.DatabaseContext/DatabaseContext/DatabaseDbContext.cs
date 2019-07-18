using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleWebAndWin.Models;
using ExampleWebAndWin.Models.Models;

namespace ExampleWebAndWin.DatabaseContext.DatabaseContext
{
    public class DatabaseDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        //public DbSet<StudentTest> StudentTests { get; set; }
    }
}
