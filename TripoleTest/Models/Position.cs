namespace TripoleTest.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public string Title { get; set; }
        public string Responsibilities { get; set; }
        public string SalaryRange { get; set; }

        public Department Department { get; set; }
    }

}
