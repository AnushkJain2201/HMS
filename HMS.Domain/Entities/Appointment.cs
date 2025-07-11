using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HMS.Domain.Enums;

namespace HMS.Domain.Entities;

public class Appointment
{
    [Key]
    public int AppointmentId { get; set; }

    [Required, StringLength(100)]
    public string DoctorId { get; set; } = null!;

    [ForeignKey("DoctorId")]
    public Doctor Doctor { get; set; } = null!;

    [Required, StringLength(100)]
    public string PatientId { get; set; } = null!;

    [ForeignKey("PatientId")]
    public Patient Patient { get; set; } = null!;

    [DataType(DataType.DateTime)]
    public DateTime AppointmentDate { get; set; }

    [Column(TypeName = "time")]
    public TimeSpan SlotStart { get; set; }

    [Column(TypeName = "time")]
    public TimeSpan SlotEnd { get; set; }

    public AppointmentStatus Status { get; set; }

    // Navigation
    public MedicalRecord? MedicalRecord { get; set; }
}