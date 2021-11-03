using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab02.Models
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        Student PostStudent(Student student);
        Student EditStudent(Student student);
        void DeleteStudent(Student student);

    }
}
