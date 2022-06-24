﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManage.Controllers
{
    [ApiController]
    [Authorize(Roles = "Employee")]
    [Route("api/[controller]")]
    public class OperationController : Controller
    {
        [HttpPost("CreateCategory")]
        public IActionResult CreateCateegory()
        {
            return Ok(0);
        }
    }
}
