using BloodDonation.Data.Entities;
using BloodDonation.Data.Enums;
using BloodDonation.Infrastructure.Context;
using BloodDonation.Infrastructure.IRepository;

namespace BloodDonation.Infrastructure.Repository
{
    public class BloodRequestRepository : IBloodRequestRepository
    {
        private readonly ApplicationDbContext _context;

        public BloodRequestRepository(ApplicationDbContext context)=> _context = context;

        public Task<bool> Add(BloodRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<BloodRequest>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<BloodRequestDonor>> GetAllDonationsByRequestId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRemainQty(int id, int remainQty)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRequestedQty(int id, int requestedQty)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStatus(int id, RequestStatus status)
        {
            throw new NotImplementedException();
        }
    }
}
