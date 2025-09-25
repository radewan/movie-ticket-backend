using MovieTicketBackend.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketBackend.Models.Entities
{
    public class User
    {
        [Key]
        [Required]
        [Column(TypeName = "uniqueidentifier")]
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [MaxLength(255)]
        [Required]
        public required string Username { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [MaxLength(255)]
        [Required]
        public required string Email { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [MaxLength(255)]
        [MinLength(8)]
        [Required]
        public required string Password { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [MaxLength(11)]
        [MinLength(7)]
        [Required]
        public Role Role { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [MaxLength(255)]
        public string? PhotoProfile { get; set; }

        [Column(TypeName = "datetime2(3)")]
        public DateTime? EmailVerifiedAt { get; set; }

        [Column(TypeName = "datetime2(3)")]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Column(TypeName = "datetime2(3)")]
        [Required]
        public DateTime UpdatedAt { get; set; }

        [Column(TypeName = "datetime2(3)")]
        public DateTime? DeletedAt { get; set; }
    }
}
