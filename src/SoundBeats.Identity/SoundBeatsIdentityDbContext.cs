using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoundBeats.Identity.Configurations;
using SoundBeats.Identity.Models;

namespace SoundBeats.Identity
{
    public class SoundBeatsIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public SoundBeatsIdentityDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}