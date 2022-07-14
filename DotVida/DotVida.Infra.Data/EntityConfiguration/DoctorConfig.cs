using DotVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotVida.Infra.Data.EntityConfiguration
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Specialty)
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.CPF)
                .HasColumnType("varchar")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(x => x.Gender)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.BloodType)
                .HasColumnType("varchar")
                .HasMaxLength(3)
                .IsRequired();

            builder.Property(x => x.Age)
                .HasMaxLength(3)
                .IsRequired();

            builder.Property(x => x.RegistrationNumber)
                .HasColumnType("varchar")
                .HasMaxLength(12)
                .IsRequired();

            builder.Property(x => x.Login)
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.Password)
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
