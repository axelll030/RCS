namespace MovieApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieDB : DbContext
    {
        public MovieDB()
            : base("name=MovieDB")
        {
        }

        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<Movy> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Cinema>()
                .Property(e => e.Adress)
                .IsFixedLength();

            modelBuilder.Entity<Cinema>()
                .HasMany(e => e.Movies)
                .WithRequired(e => e.Cinema)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movy>()
                .Property(e => e.Title)
                .IsFixedLength();
        }
    }
}
