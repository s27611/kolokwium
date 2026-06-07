using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class AppDbContext : DbContext
{
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<MedicalService> MedicalServices { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<AppointmentService> AppointmentServices { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Appointment>().HasKey(a => new { a.PatientId, a.DoctorId });
        


    }
}