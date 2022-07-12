using DotVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotVida.Infra.Data.EntityConfiguration
{
    public class PatientConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.CPF)
                .HasColumnType("varchar")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(x => x.Age)
                .HasMaxLength(3)
                .IsRequired();
        }
    }
}
