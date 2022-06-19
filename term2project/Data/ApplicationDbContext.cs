using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using term2project.Models;

namespace term2project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<term2project.Models.Cars>? Cars { get; set; }
        public DbSet<term2project.Models.Categories>? Categories { get; set; }
        public DbSet<term2project.Models.BuyingCar>? BuyingCar { get; set; }
    }
}