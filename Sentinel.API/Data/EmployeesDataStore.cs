using Sentinel.API.Models;

namespace Sentinel.API.Data;

public class EmployeesDataStore
{
    public static EmployeesDataStore Current { get; } = new();

    public List<EmployeeDTO> Employees { get; set; }

    public EmployeesDataStore()
    {
        Employees =
        [
            new EmployeeDTO()
        ];
    }
}   
