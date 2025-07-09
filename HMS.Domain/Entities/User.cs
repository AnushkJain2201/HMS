using System.ComponentModel.DataAnnotations;
using HMS.Domain.Enums;

namespace HMS.Domain.Entities;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required, MaxLength(100)] 
    public string FullName { get; set; } = null!;
    
    [Required, MaxLength(100)]
    public string Email { get; set; } = null!;
    
    [Required, MaxLength(100)]
    public string PasswordHash { get; set; } = null!;
    
    [Required]
    public UserRole Role { get; set; }
    
    [MaxLength(10)]
    public string Gender { get; set; } = null!;
    
    public DateTime DateOfBirth { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }
    
    [MaxLength(13)]
    public string ContactNum { get; set; } = null!;
    
    // Navigation Properties
    // one-to-one
    public Doctor? Doctor { get; set; }
    public Patient? Patient { get; set; }
    
    

}