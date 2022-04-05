using Homework.DataAccess;
using Homework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IStudentDataAccess _studentDataAccess;

        public StudentController(ILogger<StudentController> logger, IStudentDataAccess studentDataAccess)
        {
            _logger = logger;
            _studentDataAccess = studentDataAccess;
        }

        //Can change this route to be the basic one once I start hooking up to UI
        [HttpGet]
        [Route("students")]
        public async Task<IActionResult> GetStudents()
        {
            var result = await _studentDataAccess.GetStudents();
            return new OkObjectResult(result);
        }

        [HttpGet]
        [Route("contacts/{studentId}")]
        public async Task<IActionResult> GetContactByStudentId([FromRoute] int studentId)
        {
            var result =  await _studentDataAccess.GetContactsByStudentId(studentId);
            return new OkObjectResult(result);
        }
    }
}
