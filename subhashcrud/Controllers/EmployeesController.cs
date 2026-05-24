using Microsoft.AspNetCore.Mvc;
using subhashcrud.Model;
using subhashcrud.Interface;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly IEmployee _employee;
    public EmployeesController(IEmployee employee)
    {
        _employee = employee;
    }

    [HttpGet]
    public IActionResult GetAllEmployee()
    {
        return Ok(_employee.GetAllEmployee());
    }

    [HttpGet("{id}")]
    public IActionResult GetEmployeeById(int id)
    {
        return Ok(_employee.GetEmployeeById(id));
    }

    [HttpPost]
    public IActionResult AddEmployee([FromBody] Employee employee)
    {
        return Ok(_employee.AddEmployee(employee));
    }

    [HttpPut("{id}")]
    public IActionResult UpdateEmployee([FromBody] Employee employee)
    {
        return Ok(_employee.UpdateEmployee(employee));
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteEmployeeById(int id)
    {
        return Ok(_employee.DeleteEmployeeById(id));
    }
}
