using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales {
    [Route("api/v1/BaseController")]
    [ApiController]
    public class BaseController : ControllerBase {
        
        [HttpGet("Info")]
        public IActionResult Information() {
            return Ok(new { name = "Base Controller", version = "0.1" });
        }
    }
}
