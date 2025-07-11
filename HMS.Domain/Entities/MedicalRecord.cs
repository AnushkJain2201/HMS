using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS.Domain.Entities;

public class MedicalRecord
{
    [Key]
    public int MedicalRecordId { get; set; }

    [Required, StringLength(100)]
    public string PatientId { get; set; } = null!;

    [ForeignKey("PatientId")]
    public Patient Patient { get; set; } = null!;

    [Required, StringLength(100)]
    public string DoctorId { get; set; } = null!;

    [ForeignKey("DoctorId")]
    public Doctor Doctor { get; set; } = null!;

    [Required]
    public int AppointmentId { get; set; }

    [ForeignKey("AppointmentId")]
    public Appointment Appointment { get; set; } = null!;

    [Required]
    public string Diagnosis { get; set; } = null!;

    public string? Prescription { get; set; }

    public string? Notes { get; set; }

    public DateTime RecordDate { get; set; }
}