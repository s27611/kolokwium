using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class Appointment
{
    [Key]
    public int AppointmentId { get; set; }
    [ForeignKey(nameof(PatientId))]
    public int PatientId { get; set; }
    [ForeignKey(nameof(DoctorId))]
    public int DoctorId { get; set; }
    public DateTime AppointmentDate { get; set; }
    [MaxLength(50)]
    public String Status { get; set; }
    
    ICollection<Patient> Patients { get; set; }
    ICollection<Doctor> Doctors { get; set; }
    
}