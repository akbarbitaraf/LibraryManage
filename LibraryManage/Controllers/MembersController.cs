using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManage.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Authorize(Roles = "Member")]
    [Route("api/[controller]")]
    public class MembersController : Controller
    {
        [HttpPost("RegisterMember")]
        public async Task<IActionResult> RegisterMember()
        {
            return Ok(0);
        }
        [HttpPost("EditMember")]
        public async Task<IActionResult> EditMember()
        {
            return Ok(0);
        }


    }
}
