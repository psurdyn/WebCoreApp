using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsApp.Backend.Models;

namespace StudentsApp.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly s13619Context _context =  new s13619Context();

        public StudentsController(s13619Context context)
        {
            _context = context;
        }

        [HttpGet("getStudents")]
        public IActionResult GetStudents()
        {
            //Content negotiation
            //Accept-type: json;q=0.9;xml;q=0.5
            //select * from students
            return Ok(_context.Student.ToList());
        }
    }
}