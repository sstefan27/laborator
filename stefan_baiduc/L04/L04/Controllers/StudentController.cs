using Lab02.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static readonly IStudentRepo repository = new StudentRepo();
        // GET: api/student
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return repository.GetAllStudents();
        }

        // GET api/student/5
        [HttpGet("{id}")]
        public Student GetStudent(int id)
        {
            return repository.GetStudentById(id);
        }

        // POST api/student
        [HttpPost]
        public Student Post(Student student)
        {
            repository.PostStudent(student);
            return student;
        }

        // PUT api/student/5
        [HttpPut("{id}")]
        public Student Put(int id, Student editStudent)
        {
            var student = repository.GetStudentById(id);
            editStudent.Id = student.Id;
            repository.EditStudent(editStudent);
            return editStudent;
        }

        // DELETE api/student/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = repository.GetStudentById(id);
            repository.DeleteStudent(student);
        }
    }
}
