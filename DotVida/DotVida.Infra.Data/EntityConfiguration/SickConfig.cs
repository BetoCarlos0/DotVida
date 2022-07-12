using DotVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotVida.Infra.Data.EntityConfiguration
{
    public class SickConfig : IEntityTypeConfiguration<Sick>
    {
        public void Configure(EntityTypeBuilder<Sick> builder)
        {
            builder.HasKey(x => x.SickId);

            builder.Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
