using BlazorAppTest.Data.models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppTest.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Purchase>().HasKey(p => p.Id);
            modelBuilder.Entity<Accrual>().HasKey(p => p.Id);
            modelBuilder.Entity<ApplicationUser>().HasMany(p => p.Purchases);
            modelBuilder.Entity<ApplicationUser>().HasMany(p => p.Accruals);

            base.OnModelCreating(modelBuilder);

        }
    }
}
