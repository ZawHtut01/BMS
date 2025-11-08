using System.ComponentModel.DataAnnotations;

namespace BMS.Domain.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Branch { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public bool Status { get; set; } = false;
    }
}
