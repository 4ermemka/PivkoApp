using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PIVKO
{
    public partial class PivkoMDL : DbContext
    {
        public PivkoMDL()
            : base("name=PivkoMDL")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.RoomName)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Admin)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tasks>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Admin)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
