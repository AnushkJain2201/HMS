using System.ComponentModel.DataAnnotations;
using HMS.Domain.Enums;

namespace HMS.Domain.Entities;

public class Appointment
{
    [Key]
    public int AppointmentId { get; set; }

    [Required]
    public int PatientId { get; set; }

    [Required]
    public int DoctorId { get; set; }

    public DateTime AppointmentDate { get; set; }

    [Required]
    public AppointmentStatus Status { get; set; }

    public DateTime CreatedAt { get; set; }

    // Navigation
    // one-to-one
    public Patient Patient { get; set; } = null!;
    public Doctor Doctor { get; set; } = null!;
    public MedicalRecord? MedicalRecord { get; set; }
}