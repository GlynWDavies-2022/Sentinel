namespace Sentinel.API.Models;

public class EmployeeDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName 
    { 
        get 
        {
            return $"{FirstName} {LastName}";
        } 
    }
    public string Company { get; set; } = string.Empty;
    public string StaffNumber { get; set; } = string.Empty;
}
