using Sentinel.API.Entities;

namespace Sentinel.API.Test.Entities;

public class EmployeeTests
{
    [Fact]
    public void EmployeeFullNamePropertyGetter_InputFirstNameAndLastName_FullNameIsConcatenationOfFirstNameAndLastName()
    {
        // Arrange

        var employee = new Employee
        {
            Id = 1,
            FirstName = "Melissa",
            LastName = "Baker",
            SortCode = "111111",
            AccountNumber = "11111111",
            RollNumber = ""
        };

        // Act

        var fullName = employee.FullName;

        // Assert

        Assert.Equal("Melissa Baker", fullName);
    }
}
