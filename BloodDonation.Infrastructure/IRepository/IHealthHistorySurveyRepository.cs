using BloodDonation.Data.Entities;
using BloodDonation.Infrastructure.DTO;

namespace BloodDonation.Infrastructure.IRepository
{
    public interface IHealthHistorySurveyRepository
    {
        public Task<HealthHistorySurvey> GetByUserId(string userId);
        public Task<bool> Add(HealthHistorySurveyDTO survey);
        public Task<bool> Update(int id, HealthHistorySurveyDTO survey);
    }
}
