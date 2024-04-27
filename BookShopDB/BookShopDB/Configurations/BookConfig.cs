using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BookShopDB.Entities;

namespace BookShopDB.Configurations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.BookId).HasColumnName("Id");
            builder.Property(x => x.Name).HasMaxLength(100).HasColumnName("Title");
            builder.Property(x => x.AuthorId).HasColumnName("Author");
            builder.Property(x => x.ProductionId).HasColumnName("Production");
            builder.Property(x => x.NumberOfPages).HasColumnName("Number of pages");
            builder.Property(x => x.GenreId).HasColumnName("Genre");
            builder.Property(x => x.FullCost).HasColumnName("Original cost, $");
            builder.Property(x => x.CostForSell).HasColumnName("Selling cost, $");
            builder.Property(x => x.IsContinuation).HasColumnName("Is continuation?");

            builder.HasOne(x => x.Author).WithMany(x => x.Books).HasForeignKey(x => x.AuthorId);
            builder.HasOne(x => x.Production).WithMany(x => x.Books).HasForeignKey(x => x.ProductionId);
            builder.HasOne(x => x.Genre).WithMany(x => x.Books).HasForeignKey(x => x.GenreId);
        }
    }
}
