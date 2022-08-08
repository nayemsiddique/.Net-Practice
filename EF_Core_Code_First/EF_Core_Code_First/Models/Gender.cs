using System.ComponentModel.DataAnnotations;

namespace EF_Core_Code_First.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Display_Name { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        public bool IsAcive { get; set; }

    }
}