using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ExampleWebAndWin.DatabaseContext.DatabaseContext;
using ExampleWebAndWin.Models.Models;

namespace ExampleWebAndWin.Repository.Repository
{
    public class StudentRepository
    {
        DatabaseDbContext db = new DatabaseDbContext();
        public bool Add(Student student)
        {
            int isExecuted = 0;
            db.Students.Add(student);
            isExecuted = db.SaveChanges();
            if (isExecuted>0)
            {
                return true;
            }
            return false;
        }

        public bool Update(Student student)
        {
            int isExecuted = 0;
            db.Entry(student).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public List<Student> GetAll()
        {
            return db.Students.ToList();
        }

        public Student GetById(Student student)
        {
            Student aStudent = db.Students.FirstOrDefault();
            return aStudent;
        }
    }
}
