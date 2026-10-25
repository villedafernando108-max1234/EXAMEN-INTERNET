using EXAMENINTER.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EXAMENINTER.Infraestructure.Mappings
{
    public class PatientMapping : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.FullName).IsRequired().HasMaxLength(100);
            b.Property(x => x.NationalId).IsRequired().HasMaxLength(13);
            b.Property(x => x.BirthDate);
        }
    }
}