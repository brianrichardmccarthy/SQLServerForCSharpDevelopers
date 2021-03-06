﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers.Sales.V1.Staff {
    public partial class StaffController {
        [HttpPost("Create")]
        public IActionResult CreateStaff() {
            return Ok();
        }

        [HttpPatch("Update")]
        public IActionResult UpdateStaff() {
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteStaff() {
            return Ok();
        }
    }
}
