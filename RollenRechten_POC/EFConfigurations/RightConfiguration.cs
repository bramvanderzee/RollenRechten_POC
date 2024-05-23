using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RollenRechten_POC.Models;

namespace RollenRechten_POC.EFConfigurations
{
    public class RightConfiguration : IEntityTypeConfiguration<Right>
    {
        public void Configure(EntityTypeBuilder<Right> builder)
        {
            builder.HasKey(right => right.ID);

            // TODO add configuration
            throw new NotImplementedException();
        }
    }
}
