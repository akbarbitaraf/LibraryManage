using LibraryManage.Contract.IServices;
using LibraryManage.Entities.DTO;
using LibraryManage.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManage.Controllers
{
    [ApiController]
    [Authorize(Roles = "Employee")]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private IAuthService _authService; 
        public AuthController(IAuthService authService)
        {
            this._authService = authService; 
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] EmployeeLoginReq returnUrl)
        {
            var result =await _authService.Login(returnUrl);
 
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost("ResetPasswordWithoutLogin")]
        public async Task<IActionResult> ResetPasswordWithoutLogin([FromBody] ResetPasswordWithoutLoginReq returnUrl)
        {
            var result = _authService.ResetPasswordLogin(returnUrl.Email, returnUrl.NewPassword);
            return Ok(result);
        }

        [HttpPut("ResetPasswordAfterLogin")]
        public async Task<IActionResult> ResetPasswordAfterLogin([FromBody] ResetPasswordLoginReq returnUrl)
        {
            var email = User.Identity.Name;

            var result = await _authService.ResetPasswordLogin(email,returnUrl.NewPassword);  
            return Ok(result);
        }

    }
}
