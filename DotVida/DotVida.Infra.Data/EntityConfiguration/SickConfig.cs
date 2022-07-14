using DotVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotVida.Infra.Data.EntityConfiguration
{
    public class SickConfig : IEntityTypeConfiguration<Sick>
    {
        public void Configure(EntityTypeBuilder<Sick> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.TypeSick)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
