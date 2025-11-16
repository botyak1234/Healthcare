using Healthcare.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Healthcare.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Doctor> Doctors => Set<Doctor>();
    public DbSet<Disease> Diseases => Set<Disease>();


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Doctor>()
        .HasMany(d => d.Patients)
        .WithOne(p => p.Doctor)
        .HasForeignKey(p => p.DoctorId)
        .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Patient>()
        .HasMany(p => p.Diseases)
        .WithMany(d => d.Patients)
        .UsingEntity(j => j.ToTable("PatientDiseases"));
}

}