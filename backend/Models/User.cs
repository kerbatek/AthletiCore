using System.ComponentModel.DataAnnotations;

namespace AthletiCore.Backend.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string name { get; set; }

        [Required]
        [MaxLength(255)]
        public required string email { get; set; }

        [Required]
        [MaxLength(255)]
        public required string password_hash { get; set; }

        [Required]
        [MaxLength(20)]
        public required string role { get; set; }

        [Required]
        public DateTime created_at { get; set; } = DateTime.UtcNow;
    }
}
