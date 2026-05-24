using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using subhashcrud.Data;
using subhashcrud.Model;
namespace subhashcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CountriesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCountries()
        {
            return Ok(_context.Countries.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetCountry(int id)
        {
            return Ok(_context.Countries.Find(id));
        }

        [HttpPut]
        public IActionResult UpdateCountry(Country country)
        {
            _context.Countries.Update(country);
            _context.SaveChanges();
            return Ok("Data updated successfully!");
        }

        [HttpPost]
        public IActionResult AddCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
            return Ok("Data added successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCountryById(int id)
        {
            var country = _context.Countries.Find(id);
            _context.Countries.Remove(country);
            _context.SaveChanges();
            return Ok("Data deleted successfully!");
        }
    }
}