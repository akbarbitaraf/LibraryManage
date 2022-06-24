using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManage.Controllers
{
     [ApiController]
    [AllowAnonymous]
    [Authorize(Roles = "Employee")]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        [HttpPost("RegisterEmployee")]
        public IActionResult RegisterEmployee()
        {
            return Ok(0);
        }
        [HttpPost("EditEmployee")]
        public IActionResult EditEmployee()
        {
            return Ok(0);
        }
    }
}
