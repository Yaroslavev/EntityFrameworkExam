using System.Configuration;
using BookShopDB.Entities;
using BookShopDB.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BookShopDB
{
    public class BookShopDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public BookShopDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new ProductionConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());

            DbInitializator.InitializeData(modelBuilder);
        }
    }
}
