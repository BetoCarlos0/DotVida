using DotVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotVida.Infra.Data.EntityConfiguration
{
    public class Personal_IllnessConfig : IEntityTypeConfiguration<Personal_Illness>
    {
        public void Configure(EntityTypeBuilder<Personal_Illness> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Comments)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.StatusSick)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}
