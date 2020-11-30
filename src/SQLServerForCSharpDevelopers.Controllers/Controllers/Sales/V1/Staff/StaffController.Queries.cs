using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Staff {
    public partial class StaffController {
        [HttpGet("Read")]
        public IActionResult ReadStaff() {
            return Ok();
        }
    }
}
