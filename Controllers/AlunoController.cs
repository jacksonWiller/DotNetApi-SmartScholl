using Microsoft.AspNetCore.Mvc;
using SmartSchool.Data;

namespace SmartSchool
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IRepository repo;
        public AlunoController(IRepository repo){
            this.repo = repo;
        }
        [HttpGet]

        public IActionResult Get(){
            return Ok("Jackson");
        }
        k
    }
}