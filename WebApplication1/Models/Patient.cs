using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Patient
{
    [Key]
    public int PatientId { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(100)]
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    [MaxLength(9)]
    public string Phone {get; set;}

    public ICollection<Appointment> Appointments { get; set; }



}