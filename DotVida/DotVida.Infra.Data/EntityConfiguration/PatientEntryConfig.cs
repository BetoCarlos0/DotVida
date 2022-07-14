using DotVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotVida.Infra.Data.EntityConfiguration
{
    public class PatientEntryConfig : IEntityTypeConfiguration<PatientEntry>
    {
        public void Configure(EntityTypeBuilder<PatientEntry> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.StatusEntry)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}
