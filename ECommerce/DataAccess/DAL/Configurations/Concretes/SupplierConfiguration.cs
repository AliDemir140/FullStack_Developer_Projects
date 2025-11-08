using DAL.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations.Concretes
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.CompanyName)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.ContactName)
                   .HasMaxLength(100);

            builder.Property(x => x.ContactTitle)
                   .HasMaxLength(100);

            builder.Property(x => x.Address)
                   .HasMaxLength(250);

            builder.Property(x => x.City)
                   .HasMaxLength(100);

            builder.Property(x => x.Country)
                   .HasMaxLength(100);

            builder.Property(x => x.Phone)
                   .HasMaxLength(50);

            // İlişki: Bir Supplier'ın birçok Product'ı olabilir
            builder.HasMany(x => x.Products)
                   .WithOne(x => x.Supplier)
                   .HasForeignKey(x => x.SupplierId);

            builder.HasData(DAL.Seeds.SupplierSeeder.GetFakeSuppliers());
        }
    }
}
