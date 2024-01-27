using System.ComponentModel.DataAnnotations;

namespace ProjectCompany.Models
{
    public class Department
    {
        [Key]
        public int Dnumber { get; set; }
        [MaxLength(20)]
        public string Dname { get; set; }
        public int MGRSSN { get; set; }
        public DateTime MGRSDATE { get; set; }

    }
}
