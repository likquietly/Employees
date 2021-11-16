using System.ComponentModel.DataAnnotations;

namespace Employees
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Position { get; set; }
        [Required]
        [Range(1900, 2021)]
        public int YearOfBirth { get; set; }
        [Required]
        [Range(0, 200000)]
        public double Salary { get; set; }
    }
}