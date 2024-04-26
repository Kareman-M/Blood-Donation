using BloodDonation.Data.Entities;
using BloodDonation.Infrastructure.Context;
using BloodDonation.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BloodDonation.Infrastructure.Repository
{
    public class BloodRequestDonorRepository : IBloodRequestDonorRepository
    {
        private readonly ApplicationDbContext _context;

        public BloodRequestDonorRepository(ApplicationDbContext context) => _context = context;

        public async Task<bool> Add(int bloodrequestId , int donationQty, string userId)
        {
            var bloodDonorObj = BloodRequestDonor.Create(bloodrequestId, donationQty, userId);
            await _context.AddAsync(bloodDonorObj);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var item = await _context.BloodRequestDonors.FirstOrDefaultAsync(x => x.Id == id);
            if (item == null) return false;
            item.Removed = true;
            return await _context.SaveChangesAsync()> 0;
        }

        public async Task<IQueryable<BloodRequestDonor>> GetAll()
        {
            return _context.BloodRequestDonors.AsQueryable();
        }

        public async Task<BloodRequestDonor> GetById(int id)
        {
            return await _context.BloodRequestDonors.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateDonationQty(int id, int Qty)
        {
            var item = await _context.BloodRequestDonors.FirstOrDefaultAsync(x => x.Id == id);
            if (item == null) return;
            item.UpdateDonationQty(Qty);
            await _context.SaveChangesAsync();
        }
    }
}
