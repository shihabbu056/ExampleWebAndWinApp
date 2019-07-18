using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using ExampleWebAndWin.Models.Models;
using ExampleWebAndWin.Repository.Repository;

namespace ExampleWebAndWin.Bll.Bll
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();
        public bool Add(Student student)
        {
            return _studentRepository.Add(student);
        }

        public bool Update(Student student)
        {
            return _studentRepository.Update(student);
        }

        public bool Delete()
        {
            return true;
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public Student GetById(Student student)
        {
            return _studentRepository.GetById(student);
        }
    }
}
