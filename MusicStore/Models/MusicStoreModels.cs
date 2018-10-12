namespace MusicStore.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MusicStoreModels : DbContext
    {
        public MusicStoreModels()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Album>()
                .HasMany(e => e.Cart)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Album>()
                .HasMany(e => e.OrderDetail)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artist>()
                .HasMany(e => e.Album)
                .WithRequired(e => e.Artist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.CartId)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Album)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetail)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 2);
        }
    }
}
