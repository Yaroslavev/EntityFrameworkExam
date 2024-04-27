using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDB.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShopDB.Configurations
{
    public class ProductionConfig : IEntityTypeConfiguration<Production>
    {
        public void Configure(EntityTypeBuilder<Production> builder)
        {
            builder.Property(x => x.ProductionId).HasColumnName("Id");
            builder.Property(x => x.Name).HasMaxLength(100);

            builder.HasMany(x => x.Books).WithOne(x => x.Production).HasForeignKey(x => x.ProductionId);
        }
    }
}
