using System.ComponentModel.DataAnnotations;

namespace ProjectCompany.Models
{
    public class Project
    {
        [Key]
        public int Pnumber { get; set; }
        [MaxLength(20)]
        public string Pname { get; set; }
        public string Plocation { get; set; }
        [MaxLength(20)]
        public string City { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
