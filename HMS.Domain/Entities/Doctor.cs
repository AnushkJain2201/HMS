using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS.Domain.Entities;

public class Doctor
{
    [Key]
    [StringLength(100)]
    [ForeignKey("User")]
    public string DoctorId { get; set; } = null!;

    [Required, StringLength(100)]
    public string FullName { get; set; } = null!;

    [StringLength(200)]
    public string? Bio { get; set; }

    [StringLength(100)]
    public string? Department { get; set; }

    public bool Available { get; set; }

    public bool IsApproved { get; set; }

    [Column(TypeName = "time")]
    public TimeSpan WorkStart { get; set; }

    [Column(TypeName = "time")]
    public TimeSpan WorkEnd { get; set; }

    [StringLength(100)]
    public string? Qualification { get; set; }

    [Required, StringLength(100)]
    public string Email { get; set; } = null!;

    [Required, StringLength(13)]
    public string ContactNum { get; set; } = null!;

    public int ExperienceYears { get; set; }

    public int AppointmentsDone { get; set; }

    // Navigation Properties
    // one-to-one
    public User User { get; set; } = null!;
    
    // one-to-many
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    public ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

}