using System.ComponentModel.DataAnnotations;

namespace Mine_Monitoring.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string UserType { get; set; }
    }
}
