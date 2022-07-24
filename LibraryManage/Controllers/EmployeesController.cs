using LibraryManage.Entities.DTO;
using LibraryManage.Services.Interfaces;
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
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService )
        {
            this._employeesService = employeesService;
        }
        //Categories
        [HttpPost("CreateCategories")]
        public IActionResult CreateCategories(string CategoryTitle)
        {
            _employeesService.CreateCategories(CategoryTitle);
            return Ok(0);
        }
        [HttpPost("DeleteCategories")]
        public IActionResult DeleteCategories(long CategoryId)
        {
            _employeesService.DeleteCategories(CategoryId);
            return Ok(0);
        }
        [HttpGet("GetCategoriesByID")]
        public IActionResult GetCategoriesByID(long categoryId)
        {
            return Ok(_employeesService.GetCategoriesByID(categoryId));
        }
        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            
            return Ok(_employeesService.GetAllCategories());
        }
        // Authors
        [HttpPost("CreateAuthors")]
        public IActionResult CreateAuthors(AuthorReq authorReq)
        {
            _employeesService.CreateAuthors(authorReq);
            return Ok(0);
        }
        [HttpPut("UpdateAuthors")]
        public IActionResult UpdateAuthors(AuthorReq authorReq)
        {
            _employeesService.UpdateAuthors(authorReq);
            return Ok(0);
        }
        [HttpGet("GetAllAuthors")]
        public IActionResult GetAllAuthors()
        {
            _employeesService.GetAllAuthors();
            return Ok(0);
        }
        [HttpDelete("DeleteAuthor")]
        public IActionResult DeleteAuthor(AuthorReq authorReq)
        {
            _employeesService.DeleteAuthor(authorReq);
            return Ok(0);
        }
        //Translators
        [HttpPost("CreateTranslator")]
        public IActionResult CreateTranslator(TranslatorReq translatorReq)
        {
            var result = _employeesService.CreateTranslator(translatorReq);
            return Ok(result);
        }
        [HttpDelete("DeleteTranslator")]
        public IActionResult DeleteTranslator(int translatorID)
        {
            var result = _employeesService.DeleteTranslator(translatorID);
            return Ok(result);
        }
        [HttpGet("GetAllTranslators")]
        public IActionResult GetAllTranslators() { 
            return Ok(_employeesService.GetAllTranslators());
        }  
        [HttpPut("UpdateTranslator")]
        public IActionResult UpdateTranslator(TranslatorReq translatorReq)
        {
            var result = _employeesService.UpdateTranslator(translatorReq);
            return Ok(result);
        }

    }
}
