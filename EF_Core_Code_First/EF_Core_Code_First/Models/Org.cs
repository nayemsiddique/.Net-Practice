using System.ComponentModel.DataAnnotations;

namespace EF_Core_Code_First.Models
{
    public class Org
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? OrgName { get; set; }
        [MaxLength(500)]
        public string? Address { get; set; }

        public bool IsActive { get; set; }
    }
}
