using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SafeVaultApp.Models; // <- important

namespace SafeVaultApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<VaultItem> VaultItems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
