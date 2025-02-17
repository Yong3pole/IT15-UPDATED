namespace TripoleTest.Models
{
    public class Performance
    {
        public int PerformanceId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Score { get; set; }
        public string ReviewComments { get; set; }
        public int ManagerId { get; set; }

        public Employee Employee { get; set; }
        public Employee Manager { get; set; }
    }

}
