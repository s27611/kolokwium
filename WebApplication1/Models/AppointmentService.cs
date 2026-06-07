using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class AppointmentService
{
    [Key]
    public int AppointmentId { get; set; }
    [Key]
    public int ServiceId { get; set; }
    public int Quantity { get; set; }
    public DateTime PerformedAt { get; set; }
    
    ICollection<Appointment> Appointments { get; set; }
    ICollection<MedicalService> MedicalServices { get; set; }
}