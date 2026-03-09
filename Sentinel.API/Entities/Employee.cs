using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sentinel.API.Entities;

public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public required string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public required string LastName { get; set; }

    [NotMapped]
    public string FullName 
    { 
        get 
        {
            return $"{FirstName} {LastName}";
        }
    }

    [Required]
    [MaxLength(6)]
    public required string SortCode { get; set; }

    [Required]
    [MaxLength(8)]
    public required string AccountNumber { get; set; }

    [Length(0,16)]
    public required string RollNumber { get; set; }
}
