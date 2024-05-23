using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RollenRechten_POC.Models;

namespace RollenRechten_POC.EFConfigurations
{
    public class RightsGroupConfiguration : IEntityTypeConfiguration<RightsGroup>
    {
        public void Configure(EntityTypeBuilder<RightsGroup> builder)
        {
            builder.HasKey(rightsGroup => rightsGroup.ID);

            // TODO add configuration
            throw new NotImplementedException();
        }
    }
}
