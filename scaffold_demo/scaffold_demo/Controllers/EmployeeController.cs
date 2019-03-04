using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using scaffold_demo.DtoModels;

namespace scaffold_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Produces("application/json")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Post([FromBody] DtoEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}