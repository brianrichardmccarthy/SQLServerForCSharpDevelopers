using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Address {
    public partial class AddressController {
        [HttpPost("Create")]
        public IActionResult CreateAddress() {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateAddress() {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteAddress() {
            return Ok();
        }
    }
}
