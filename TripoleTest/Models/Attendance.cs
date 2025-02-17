﻿namespace TripoleTest.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public decimal OvertimeHours { get; set; }
        public string Status { get; set; }

        public Employee Employee { get; set; }
    }

}
