using BloodDonation.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BloodDonation.Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BloodRequest> BloodRequests { get; set; }
        public DbSet<BloodRequestDonor> BloodRequestDonors { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<HealthHistorySurvey> HistorySurveys { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
