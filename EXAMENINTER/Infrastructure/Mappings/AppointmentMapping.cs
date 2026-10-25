using EXAMENINTER.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EXAMENINTER.Infrastructure.Mappings
{
    public class AppointmentMapping : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Date);
            b.Property(x => x.Reason).IsRequired().HasMaxLength(250);
            b.HasOne(x => x.Patient)
             .WithMany(p => p.Appointments)
             .HasForeignKey(x => x.PatientId);
            b.HasOne(x => x.Doctor)
             .WithMany(d => d.Appointments)
             .HasForeignKey(x => x.DoctorId);
        }
    }
}
