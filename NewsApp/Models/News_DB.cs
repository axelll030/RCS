namespace NewsApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class News_DB : DbContext
    {
        public News_DB()
            : base("name=News_DB")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
                .Property(e => e.Article)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.News)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Topic>()
                .HasMany(e => e.News)
                .WithRequired(e => e.Topic)
                .WillCascadeOnDelete(false);
        }
    }
}
