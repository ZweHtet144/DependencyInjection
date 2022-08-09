using DependencyInjectionWithDBService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionWithDBService.Services.Interface
{
    public interface IStudentInterface
    {
        List<StudentModel> GetAllStudentList();
    }
}
