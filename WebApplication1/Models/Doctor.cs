using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Doctor
{
    [Key]
    public int DoctorId { get; set; }
    [MaxLength(50)]
    public String FirstName { get; set; }
    [MaxLength(100)]
    public String LastName { get; set; }
    [MaxLength(100)]
    public String Specialization { get; set; }
    [MaxLength(9)]
    public String Phone { get; set; }
   
    public ICollection<Appointment> Appointments { get; set; }
}