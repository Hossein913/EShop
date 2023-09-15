using App.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructures.Db.SqlServer.Ef.Configuration
{
    public class OrderConfiguration: IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(o => o.Cart)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CartId);

            builder.HasOne(o => o.Product)
              .WithOne(c => c.Order)
              .HasForeignKey<Order>(o => o.ProductId);

        }
    }
}
