using System.ComponentModel.DataAnnotations;

namespace TripoleTest.Models
{
    public class JobPosting
    {
        public int JobPostingId { get; set; }
        public string JobTitle { get; set; }
        public int DepartmentId { get; set; }
        public string Description { get; set; }
        public string RequiredSkills { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime ClosingDate { get; set; }

        public Department Department { get; set; }
    }

}
