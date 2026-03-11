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
            new EmployeeDTO 
            {
                Id = 1,
                FirstName = "Erin",
                LastName = "Reagan",
                Company = "Domicile",
                StaffNumber = "111111"
            },
            new EmployeeDTO
            {
                Id = 2,
                FirstName = "Garrett",
                LastName = "Moore",
                Company = "Beachfront",
                StaffNumber = "111112"
            },
            new EmployeeDTO
            {
                Id = 3,
                FirstName = "Abigail",
                LastName = "Baker",
                Company = "Lakeside",
                StaffNumber = "111113"
            },
        ];
    }
}   
