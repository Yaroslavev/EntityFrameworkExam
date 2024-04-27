using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopDB.Configurations
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(x => x.GenreId).HasColumnName("Id");
            builder.Property(x => x.Name).HasMaxLength(50);

            builder.HasMany(x => x.Books).WithOne(x => x.Genre).HasForeignKey(x => x.GenreId);
        }
    }
}
