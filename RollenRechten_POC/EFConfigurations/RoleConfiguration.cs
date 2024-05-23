using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RollenRechten_POC.Models;

namespace RollenRechten_POC.EFConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(role => role.ID);

            // TODO add configuration
            throw new NotImplementedException();
        }
    }
}
