using BloodDonation.Data.Entities;
using BloodDonation.Infrastructure.Context;
using BloodDonation.Infrastructure.DTO;
using BloodDonation.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BloodDonation.Infrastructure.Repository
{
    public class HealthHistorySurveyRepository : IHealthHistorySurveyRepository
    {
        private readonly ApplicationDbContext _context;

        public HealthHistorySurveyRepository(ApplicationDbContext context) => _context = context;

        public async Task<bool> Add(HealthHistorySurveyDTO survey)
        {
            var obj = HealthHistorySurvey.Create(survey.UserId, survey.Comment, survey.Surgeries, survey.LastPhysicalExamination, survey.OtherDisease,
                survey.IsHasASexuallyTransmittedDiseases, survey.IsHasADepression, survey.IsHasAKidneyDisease, survey.IsHasAHeartDisease, survey.IsHasADiabetes, survey.MaritalStatus);

           await _context.HistorySurveys.AddAsync(obj);
            return await _context.SaveChangesAsync() > 0;
        }


        public async Task<HealthHistorySurvey> GetByUserId(string userId)
        {
            return await _context.HistorySurveys.FirstOrDefaultAsync(x => x.UserId == userId);
        }

        public async Task<bool> Update(int id, HealthHistorySurveyDTO survey)
        {
            var obj = _context.HistorySurveys.FirstOrDefault(x => x.Id == id);
            if (obj == null) return false;
            obj.Update(survey.UserId, survey.Comment, survey.Surgeries, survey.LastPhysicalExamination, survey.OtherDisease, survey.IsHasASexuallyTransmittedDiseases, survey.IsHasADepression, survey.IsHasAKidneyDisease, survey.IsHasAHeartDisease, survey.IsHasADiabetes, survey.MaritalStatus);
            return await _context.SaveChangesAsync()> 0;
        }

    }
}
