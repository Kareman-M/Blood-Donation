using BloodDonation.Data.Entities;
using BloodDonation.Data.Enums;

namespace BloodDonation.Infrastructure.IRepository
{
    public interface IBloodRequestDonorRepository
    {
        public Task<IQueryable<BloodRequestDonor>> GetAll();
        public Task<BloodRequestDonor> GetById(int id);
        public Task<bool> Add(int bloodrequestId, int donationQty, string userId);
        public Task UpdateDonationQty(int id , int Qty);
        public Task<bool> Delete(int id);
    }
}
