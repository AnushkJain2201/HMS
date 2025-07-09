using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS.Domain.Entities;

public class Patient
{
    [Key, ForeignKey("User")]
    public int PatientId { get; set; }

    [MaxLength(100)]
    public string MedicalHistory { get; set; } = null!;
    
    // Navigation Properties
    // one-to-one
    public User User { get; set; } = null!;
    
    // one-to-many
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    public ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
}