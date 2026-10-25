using EXAMENINTER.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EXAMENINTER.Infrastructure.Mappings
{
    public class DoctorMapping : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.LicenseNumber).IsRequired().HasMaxLength(20);
            b.HasOne(x => x.Specialty)
             .WithMany(s => s.Doctors)
             .HasForeignKey(x => x.SpecialtyId);
        }
    }
}