using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS.Domain.Entities;

public class MedicalRecord
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RecordId { get; set; }

    [Required]
    public int PatientId { get; set; }

    [Required]
    public int DoctorId { get; set; }

    [Required]
    public int AppointmentId { get; set; }

    public string Diagnosis { get; set; } = null!;
    public string Prescription { get; set; } = null!;
    public string Notes { get; set; } = null!;
    public DateTime RecordDate { get; set; }

    // Navigation Properties
    // one-to-one
    public Patient Patient { get; set; } = null!;
    public Doctor Doctor { get; set; } = null!;
    public Appointment Appointment { get; set; } = null!;
}