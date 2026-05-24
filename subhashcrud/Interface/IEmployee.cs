using subhashcrud.Model;

namespace subhashcrud.Interface
{

    public interface IEmployee
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        bool AddEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployeeById(int id);
    }
}