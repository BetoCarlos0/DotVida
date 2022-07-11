using DotVida.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotVida.Infra.Data.Context
{
    public class DotVidaDbContext : DbContext
    {
        public DotVidaDbContext(DbContextOptions<DotVidaDbContext> options) : base(options) { }

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientEntry> PatientsEntry { get; set; }
        public DbSet<Personal_Illness> Personal_Illnesses { get; set; }
        public DbSet<Sick> Sicks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DotVidaDbContext).Assembly);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity.GetType().GetProperty("CreatedDate") != null ||
                    e.Entity.GetType().GetProperty("DateEntry") != null);

            foreach (var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Property("CreatedDate").CurrentValue = DateTime.Now;
                }
                if (entityEntry.State == EntityState.Modified)
                {
                    entityEntry.Property("CreatedDate").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
