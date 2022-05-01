using LibraryManage.Contract.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles ="Memmber")]
    public class AuthController : Controller
    {
        private readonly IRepositoryManager _repositoryManager;
        public AuthController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl)
        {
            return Ok(returnUrl);
        }


    }
}
