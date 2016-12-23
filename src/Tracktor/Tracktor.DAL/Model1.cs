namespace Tracktor.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Contents_Info> Contents_Info { get; set; }
        public virtual DbSet<Reputation> Reputations { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Contents_Info)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.Category_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Content>()
                .HasOptional(e => e.Contents_Info)
                .WithRequired(e => e.Content)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Content>()
                .HasOptional(e => e.Contents_Info1)
                .WithMany(e => e.Contents);

            modelBuilder.Entity<Reputation>()
                .HasMany(e => e.Contents)
                .WithRequired(e => e.Reputation)
                .HasForeignKey(e => e.Reputation_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reputation>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Reputations)
                .Map(m => m.ToTable("VotedNegative").MapLeftKey("Reputations1_id").MapRightKey("VotedNegative_Id"));

            modelBuilder.Entity<Reputation>()
                .HasMany(e => e.Users1)
                .WithMany(e => e.Reputations1)
                .Map(m => m.ToTable("VotedPositive").MapLeftKey("Reputations_id").MapRightKey("VotedPositive_Id"));

            modelBuilder.Entity<User>()
                .HasMany(e => e.Contents)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
