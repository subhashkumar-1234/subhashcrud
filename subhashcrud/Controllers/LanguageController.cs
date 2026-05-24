using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using subhashcrud.Data;
using subhashcrud.Model;
namespace subhashcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDbContext _context;
        public LanguageController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetLanguages()
        {
            return Ok(_context.Languages.ToList());
        }

        [HttpPost]
        public IActionResult AddLanguage(Language language)
        {
            _context.Languages.Add(language);
            _context.SaveChanges();
            return Ok("Language Added SUccessfully");
        }


        [HttpPut]
        public IActionResult UpdateLanguage(Language language)
        {
            _context.Languages.Update(language);
            _context.SaveChanges();
            return Ok("Language updated SUccessfully");

        }


        [HttpDelete]
        public IActionResult DeleteLanguage(int id)
        {
            var language = _context.Languages.Find(id);
            _context.Languages.Remove(language);
            return Ok("Language Deleted SUccessfully");
        }

      }

}
