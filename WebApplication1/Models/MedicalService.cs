using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class MedicalService
{
    [Key]
    public int ServiceId { get; set; }
    [MaxLength(100)]
    public String Name { get; set; }
    [MaxLength(100)]
    public String Description { get; set; }
    
    public double Price { get; set; }
    public int DurationMinutes { get; set; } 
    
    ICollection<AppointmentService> AppointmentServices { get; set; }
}