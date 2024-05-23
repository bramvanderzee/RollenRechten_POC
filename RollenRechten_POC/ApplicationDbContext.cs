using Microsoft.EntityFrameworkCore;
using RollenRechten_POC.Models;
using System.Reflection;

namespace RollenRechten_POC
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Right> Right { get; set; }
        public DbSet<RightsGroup> RightsGroups { get; set; }
        public DbSet<Role> Roles { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}
    }
}
