using System.ComponentModel.DataAnnotations;

namespace TripoleTest.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public int DepartmentId { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string PerformanceData { get; set; }

        public Department Department { get; set; }
    }

}
