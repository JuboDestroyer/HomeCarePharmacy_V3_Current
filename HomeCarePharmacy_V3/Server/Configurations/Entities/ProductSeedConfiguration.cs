using HomeCarePharmacy_V3.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeCarePharmacy_V3.Server.Configurations.Entities
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
           new Product
           {
               Price = 20,
               ProductId = 1,
               Name = "Panadol",
               Description = "Medicine for Headaches",
               Quantity = 1,
               Category = 1
           },
            new Product
            {
                Price = 30,
                ProductId = 2,
                Name = "Nin Jiom Pei Pa Koa",
                Description = "Medicine for Cough",
                Quantity = 1,
                Category = 2
            }
            );
        }
    }
}
