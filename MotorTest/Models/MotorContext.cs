using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MotorTest
{
    public partial class MotorContext : DbContext
    {
        public MotorContext()
            : base("name=MotorContext")
        {
        }

        public virtual DbSet<carburant> carburants { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<constructeur> constructeurs { get; set; }
        public virtual DbSet<modele> modeles { get; set; }
        public virtual DbSet<option> options { get; set; }
        public virtual DbSet<peinture> peintures { get; set; }
        public virtual DbSet<voiture> voitures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<carburant>()
                .Property(e => e.nomCarvurant)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.codePostal)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.ville)
                .IsUnicode(false);

            modelBuilder.Entity<constructeur>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<constructeur>()
                .HasMany(e => e.modeles)
                .WithRequired(e => e.constructeur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<modele>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<modele>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<option>()
                .Property(e => e.nomOption)
                .IsUnicode(false);

            modelBuilder.Entity<peinture>()
                .Property(e => e.nomPeinture)
                .IsUnicode(false);

            modelBuilder.Entity<voiture>()
                .Property(e => e.idCarburant)
                .IsUnicode(false);

            modelBuilder.Entity<voiture>()
                .Property(e => e.typeTransmission)
                .IsUnicode(false);

            modelBuilder.Entity<voiture>()
                .Property(e => e.finition)
                .IsUnicode(false);
        }
    }
}
