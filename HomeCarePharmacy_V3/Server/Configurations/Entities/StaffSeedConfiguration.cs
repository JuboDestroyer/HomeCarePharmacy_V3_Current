using HomeCarePharmacy_V3.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HomeCarePharmacy_V3.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
            new Staff
            {
                StaffId = 1,
                Gender = "Male",
                Name = "Johnny Boy",
            },
            new Staff
            {
                StaffId = 2,
                Gender = "Female",
                Name = "Missy",
            }
            );
        }
    }
}
