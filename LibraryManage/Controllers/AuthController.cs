using LibraryManage.Contract.IServices;
using LibraryManage.Entities.DTO;
using LibraryManage.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManage.Controllers
{
    [ApiController]
    //[Authorize(Roles = "Members")]
    [Route("api/[controller]")]
    //[Authorize(Roles ="Memmber")]
    public class AuthController : Controller
    {
        private IAuthService _authService; 
        public AuthController(IAuthService authService)
        {
            this._authService = authService; 
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] MemberLoginReq returnUrl)
        {
            var result =await _authService.Login(returnUrl);
 
            return Ok(returnUrl);
        }


    }
}
