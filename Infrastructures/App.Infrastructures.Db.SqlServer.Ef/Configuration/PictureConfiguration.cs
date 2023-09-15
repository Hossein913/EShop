using App.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infrastructures.Db.SqlServer.Ef.Configuration
{
    public class PictureConfiguration: IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.HasOne(pc => pc.Product)
                .WithMany(pr => pr.Pictures)
                .HasForeignKey(pc => pc.ProductId);
        }
    }
}
