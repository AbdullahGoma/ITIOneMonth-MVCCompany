using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectCompany.Models
{
    public class WorksFor
    {
        [Key]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ProjectNo { get; set; }
        public Project Project { get; set; }
        public float Hours { get; set; }

    }
}
