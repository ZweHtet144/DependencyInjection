using DependencyInjectionWithDBService.Models;
using DependencyInjectionWithDBService.Services.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionWithDBService.DAO.StudentDAO
{
    public class StudentDAO
    {
        private readonly EFDBContext _db;
        public StudentDAO(EFDBContext db)
        {
            _db = db;
        }

        public List<StudentModel> SelectStudentList()
        {
            var studentList = _db.Students.ToList();
            return studentList;
        }
    }
}
