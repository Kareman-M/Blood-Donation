using BloodDonation.Data.Entities;
using BloodDonation.Data.Enums;

namespace BloodDonation.Infrastructure.IRepository
{
    public interface IBloodRequestRepository
    {
        public Task<IQueryable<BloodRequest>> GetAll();
        public Task<List<BloodRequestDonor>> GetAllDonationsByRequestId(int id);
        public Task<bool> Add(BloodRequest request);
        public Task<bool> UpdateStatus(int id, RequestStatus status);
        public Task<bool> UpdateRemainQty(int id, int remainQty);
        public Task<bool> UpdateRequestedQty(int id, int requestedQty);
        public Task<bool> Delete(int id);
    }
}
