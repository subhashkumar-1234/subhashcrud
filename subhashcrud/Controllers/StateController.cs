using Microsoft.AspNetCore.Mvc;
using subhashcrud.Data;
using subhashcrud.Model;

[Route("api/[controller]")]
[ApiController]
public class StatesController : ControllerBase
{
    private readonly AppDbContext _context;

    public StatesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetStates()
    {
        return Ok(_context.States.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetState(int id)
    {
        return Ok(_context.States.Find(id));
    }

    [HttpPut]
    public IActionResult UpdateState(State state)
    {
        _context.States.Update(state);
        _context.SaveChanges();
        return Ok("Data updated successfully!");
    }

    [HttpPost]
    public IActionResult AddState(State state)
    {
        _context.States.Add(state);
        _context.SaveChanges();
        return Ok("Data added successfully!");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStateById(int id)
    {
        var state = _context.States.Find(id);
        _context.States.Remove(state);
        _context.SaveChanges();
        return Ok("Data deleted successfully!");
    }
}