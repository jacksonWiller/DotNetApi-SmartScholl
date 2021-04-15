using System;
using Microsoft.AspNetCore.Mvc;

namespace SmartSchool
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get(){
            return Ok("Jackson");
        }
    }
}