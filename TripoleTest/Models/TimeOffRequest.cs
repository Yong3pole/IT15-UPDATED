namespace TripoleTest.Models
{
    public class TimeOffRequest
    {
        public int TimeOffRequestId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TypeOfLeave { get; set; }
        public string Status { get; set; }

        public Employee Employee { get; set; }
    }

}
