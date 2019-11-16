namespace RPBD_2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Sched : DbContext
    {
        public Sched()
            : base("name=Sched")
        {
        }

        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Priem> Priems { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Specialty> Specialtys { get; set; }
        public virtual DbSet<StatPatient> StatPatients { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disease>()
                .Property(e => e.name_Disease)
                .IsFixedLength();

            modelBuilder.Entity<Doctor>()
                .Property(e => e.FIO)
                .IsFixedLength();

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.FIO)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.address)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.telefon)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Priems)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasOptional(e => e.Schedule)
                .WithRequired(e => e.Patient);

            modelBuilder.Entity<Priem>()
                .Property(e => e.prtim)
                .IsFixedLength();

            modelBuilder.Entity<Schedule>()
                .HasMany(e => e.Priems)
                .WithRequired(e => e.Schedule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specialty>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Specialty>()
                .Property(e => e.Obyaz)
                .IsFixedLength();

            modelBuilder.Entity<Specialty>()
                .HasMany(e => e.Doctors)
                .WithRequired(e => e.Specialty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatPatient>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<StatPatient>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.StatPatient)
                .WillCascadeOnDelete(false);
        }
    }
}
