using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Address {
    public partial class AddressController {
        [HttpGet("Read")]
        public IActionResult ReadAddress() {
            return Ok();
        }
    }
}
