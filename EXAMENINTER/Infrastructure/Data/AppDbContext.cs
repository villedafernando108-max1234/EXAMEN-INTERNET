using EXAMENINTER.Domain.Entities;
using EXAMENINTER.Infraestructure.Mappings;
using EXAMENINTER.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace EXAMENINTER.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Specialty> Specialties => Set<Specialty>();
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Doctor> Doctors => Set<Doctor>();
    public DbSet<Appointment> Appointments => Set<Appointment>();
    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.ApplyConfiguration(new SpecialtyMapping());
        mb.ApplyConfiguration(new PatientMapping());
        mb.ApplyConfiguration(new DoctorMapping());
        mb.ApplyConfiguration(new AppointmentMapping());
    }
}