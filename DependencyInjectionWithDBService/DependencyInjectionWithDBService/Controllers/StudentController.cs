using DependencyInjectionWithDBService.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionWithDBService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private IStudentInterface _iStudentInterface;
        public StudentController(IStudentInterface iStudentInterface)
        {
            _iStudentInterface = iStudentInterface;
        }

        [HttpGet]
        [Route("api/studentlist")]
        public string GetAllStudentList()
        {
            var responseModel = _iStudentInterface.GetAllStudentList();
            return JsonConvert.SerializeObject(responseModel);
        }
    }
}
