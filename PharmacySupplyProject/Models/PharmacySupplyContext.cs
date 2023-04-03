using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PharmacySupplyProject.Models;

namespace PharmacySupplyProject.Models
{
    public class PharmacySupplyContext : DbContext
    {
        public PharmacySupplyContext() { }

        public PharmacySupplyContext(DbContextOptions<PharmacySupplyContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalRepresentative>(entity =>
            {
                entity.HasIndex(u => u.Id).IsUnique();
                entity.HasIndex(u => u.ContactNumber).IsUnique();
            });

            modelBuilder.Entity<MedicineStock>(entity =>
            {
                entity.HasIndex(u => u.Name).IsUnique();
                entity.HasIndex(u => u.ChemicalComposition).IsUnique();
            });

            modelBuilder.Entity<RepresentativeSchedule>().HasKey(x => new { x.RepresentativeName, x.DoctorName });

        }

        public virtual DbSet<MedicineStock> MedicineStocks { get; set;}
        public virtual DbSet<MedicalRepresentative> MedicalRepresentatives { get; set;}
        public virtual DbSet<RepresentativeSchedule> RepresentativeSchedules { get; set; }


    }
}
