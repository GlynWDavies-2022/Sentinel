using Microsoft.AspNetCore.Mvc;
using Sentinel.API.Data;

namespace Sentinel.API.Controllers;

[ApiController]
[Route("api/employees")]
public class EmployeesController : ControllerBase
{
    [HttpGet]
    public ActionResult GetEmployees()
    {
        return Ok(EmployeesDataStore.Current.Employees);
    }

    [HttpGet("{id}")]
    public ActionResult GetEmployeeById(int id)
    {
        var employee = EmployeesDataStore.Current.Employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            return NotFound();
        }

        return Ok(employee);
    } 
}
