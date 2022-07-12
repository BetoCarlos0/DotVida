using DotVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotVida.Infra.Data.EntityConfiguration
{
    public class AttendanceConfig : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasKey(x => x.AttendanceId);
            builder.Property(x => x.Weight)
                .HasPrecision(3, 2)
                .IsRequired();

            builder.Property(x => x.Height)
                .HasPrecision(1, 2)
                .IsRequired();

            builder.Property(x => x.CommentsDoctor)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
