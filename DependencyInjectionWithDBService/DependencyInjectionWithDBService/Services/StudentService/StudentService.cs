using DependencyInjectionWithDBService.DAO.StudentDAO;
using DependencyInjectionWithDBService.Models;
using DependencyInjectionWithDBService.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionWithDBService.Services.StudentService
{
    public class StudentService:IStudentInterface
    {
        private readonly StudentDAO _studentDAO;

        public StudentService(StudentDAO studentDAO)
        {
            _studentDAO = studentDAO;
        }

        public List<StudentModel> GetAllStudentList()
        {
            var studentList = _studentDAO.SelectStudentList();
            return studentList;
        }
    }
}
