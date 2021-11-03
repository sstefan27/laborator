using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab02.Models
{
    public class StudentRepo : IStudentRepo
    {
        private List<Student> studentList;

        public StudentRepo()
        {
            studentList = new List<Student>()
            {
                new Student { Id = 1, FirstName = "John", LastName = "Doe", University = "Politehnica", Year = 4},
                new Student { Id = 2, FirstName = "Andre", LastName = "Doe", University = "no", Year = 3},
                new Student { Id = 3, FirstName = "Mie", LastName = "Doe", University = "West", Year = 2},
                new Student { Id = 4, FirstName = "Sqwe", LastName = "Doe", University = "Timis", Year = 1},
                new Student { Id = 5, FirstName = "New", LastName = "Doe", University = "Politehnica", Year = 5},
                new Student { Id = 6, FirstName = "Name", LastName = "Doe", University = "Politehnica", Year = 0},
            };
        }

        public void DeleteStudent(Student student)
        {
            studentList.Remove(student);
        }

        public Student EditStudent(Student student)
        {
            var editStudent = GetStudentById(student.Id);
            editStudent.FirstName = student.FirstName;
            editStudent.LastName = student.LastName;
            editStudent.University = student.University;
            editStudent.Year = student.Year;
            return editStudent;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return studentList;
        }

        public Student GetStudentById(int id)
        {
            return studentList.FirstOrDefault(x => x.Id == id);
        }

        public Student PostStudent(Student student)
        {
            studentList.Add(student);
            return student;
        }
    }
}
