using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS.Domain.Entities;

public class Patient
{
    [Key]
    [StringLength(100)]
    [ForeignKey("User")]
    public string PatientId { get; set; } = null!;

    [Required, StringLength(100)]
    public string FullName { get; set; } = null!;

    [StringLength(10)]
    public string? Gender { get; set; }

    [Required, StringLength(100)]
    public string Email { get; set; } = null!;

    [Required, StringLength(13)]
    public string ContactNum { get; set; } = null!;

    [DataType(DataType.Date)]
    public DateTime Age { get; set; }

    // Navigation collections
    // one-to-one
    public User User { get; set; } = null!;
    
    // one-to-many
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    public ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
}