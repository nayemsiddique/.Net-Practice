using System.ComponentModel.DataAnnotations;

namespace EF_Core_Code_First.Models
{
    public class UserType
    {

        public int Id { get; set; }

        [MaxLength(100)]
        public string Display_Name { get; set; } = string.Empty;

        [MaxLength(2)]
        public string Sort_Name { get; set; }

        public string? Description { get; set; }
        public bool? IsActive { get; set; }


    }
}