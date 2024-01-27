using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectCompany.Models
{
    public class Dependent
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        [MaxLength(20)]
        public string RelationShip { get; set; }
        public char Gender { get; set; }
    }
}
