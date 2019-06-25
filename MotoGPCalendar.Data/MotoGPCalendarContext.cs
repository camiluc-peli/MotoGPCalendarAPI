using Microsoft.EntityFrameworkCore;
using MotoGPCalendar.Domain.Entities;

namespace MotoGPCalendar.Data
{
    public class MotoGPCalendarContext : DbContext
    {
        public DbSet<MotoGPEvent> MotoGPEvent { get; set; }
        public DbSet<Circuit> Circuit { get; set; }
        public DbSet<Country> Country { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=MotoGPCalendar;Uid=root;Pwd=Camila.2019;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired(); ;
                entity.Property(e => e.Code).IsRequired();
                entity.Property(e => e.Alpha2Code).IsRequired();
                entity.Property(e => e.Alpha3Code).IsRequired();
            });

            modelBuilder.Entity<Circuit>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.HasOne(e => e.Country);
                entity.Property(e => e.Length);
                entity.Property(e => e.Width);
                entity.Property(e => e.CurvesNumber);
                entity.Property(e => e.LongestStraight);
                entity.Property(e => e.Record);
            });

            modelBuilder.Entity<MotoGPEvent>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.EventDate);
                entity.Property(e => e.EventName).IsRequired();
                entity.HasOne(e => e.Circuit);
            });
        }
    }
}
