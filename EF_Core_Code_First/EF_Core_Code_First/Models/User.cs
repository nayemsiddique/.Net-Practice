using System.ComponentModel.DataAnnotations;

namespace EF_Core_Code_First.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string First_Name { get; set; }
        [MaxLength(100)]
        public string  Last_Name { get; set; }
        public int? Age { get; set; }
        public Gender? Gender { get; set; }

        public UserType UserType { get; set; }

        public bool? IsActive { get; set; }

        
        public Org Org { get; set; }
       

        
    }
}
