using System.ComponentModel.DataAnnotations;

namespace ProjectCompany.Models
{
    public class Entity<T>
    {
        [Key]
        public T Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsVisable { get; set; }
    }
}
