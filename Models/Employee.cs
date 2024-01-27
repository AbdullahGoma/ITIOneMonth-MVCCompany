using System.ComponentModel.DataAnnotations;

namespace ProjectCompany.Models
{
    public class Employee : Entity<int>
    {
        [MaxLength(20)]
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime BDATE { get; set; }
        [MaxLength(80)]
        public string Address { get; set; }
        public int Phone { get; set; }
        public char Gender { get; set; }
        [Range(12000, 150000)]
        public float Salary { get; set; }
        public Employee? Employe { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
