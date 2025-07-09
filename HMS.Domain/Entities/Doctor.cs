using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS.Domain.Entities;

public class Doctor
{
    [Key, ForeignKey("User")]
    public int DoctorId { get; set; }

    [MaxLength(200)] 
    public string Bio { get; set; } = null!;
    
    [MaxLength(100)]
    public string Department { get; set; } = null!;

    public bool Availability { get; set; }

    [MaxLength(100)] 
    public string Qualification { get; set; } = null!;
    
    public int ExperienceYears { get; set; }

    public int AppointmentsDone { get; set; }
    
    // Navigation Properties
    // one-to-one
    public User User { get; set; } = null!;
    
    // one-to-many
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    public ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

}