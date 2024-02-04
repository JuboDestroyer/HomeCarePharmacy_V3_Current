using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeCarePharmacy_V3.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },
            new IdentityRole
            {
                Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                Name = "User",
                NormalizedName = "USER"
            },
            new IdentityRole
            {
                Id = "cd2bcf0c-20db-474f-8407-5a6b159518bc",
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            }
            );
        }
    }
}