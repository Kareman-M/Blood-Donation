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

        DbSet<BloodRequest> BloodRequests { get; set; }
        DbSet<Campaign> Campaigns { get; set; }
        DbSet<Hospital> Hospitals { get; set; }
        DbSet<HistorySurvey> HistorySurveys { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
