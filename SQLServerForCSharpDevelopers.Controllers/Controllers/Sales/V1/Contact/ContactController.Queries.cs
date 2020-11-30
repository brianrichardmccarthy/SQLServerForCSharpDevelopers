using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Contact {
    public partial class ContactController {
        [HttpGet("Read")]
        public IActionResult ReadContact() {
            return Ok();
        }
    }
}
