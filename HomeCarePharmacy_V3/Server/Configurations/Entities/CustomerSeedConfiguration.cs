using HomeCarePharmacy_V3.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HomeCarePharmacy_V3.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
            new Customer
            {
                CustomerId = 1,
                Address = "Hougang",
                Email = "johnPeng@gmail.com",
                Name = "John",
                PhoneNumber = 1234879
            },
            new Customer
            {
                CustomerId = 2,
                Address = "Sengkang",
                Email = "melissaTeng@gmail.com",
                Name = "Melissa",
                PhoneNumber = 1234879
            }
            );
        }
    }
}
