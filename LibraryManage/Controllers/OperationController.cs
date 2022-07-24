using LibraryManage.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManage.Controllers
{
    [ApiController]
 //   [Authorize(Roles = "Employee")]
    [Route("api/[controller]")]
    public class OperationController : Controller
    {
        private readonly IOperationService _operationService;

        public OperationController(IOperationService operationService)
        {
            this._operationService = operationService;
        }
        [HttpPost("CreateCategory")]
        public IActionResult CreateCateegory(string CategoryTitle)
        {
            _operationService.CreateCategory(CategoryTitle); 
            return Ok(0);
        }
    }
}
