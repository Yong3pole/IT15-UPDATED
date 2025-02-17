namespace TripoleTest.Models
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Resume { get; set; }
        public int JobPostingId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; }

        public JobPosting JobPosting { get; set; }
    }

}
