namespace TripoleTest.Models
{
    public class Payroll
    {
        public int PayrollId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime PayPeriodStart { get; set; }
        public DateTime PayPeriodEnd { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal TaxDeductions { get; set; }
        public decimal BenefitsDeductions { get; set; }
        public decimal NetSalary { get; set; }
        public DateTime PaymentDate { get; set; }

        public Employee Employee { get; set; }
    }

}
