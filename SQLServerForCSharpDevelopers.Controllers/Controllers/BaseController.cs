using Microsoft.AspNetCore.Mvc;

namespace SQLServerForCSharpDevelopers.Controllers.Controllers {
    [Route("api/[controller]/v1/")]
    [ApiController]
    public abstract class BaseController : ControllerBase {
    }
}
