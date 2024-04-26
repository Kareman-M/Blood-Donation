using BloodDonation.Data.Enums;

namespace BloodDonation.Infrastructure.DTO
{
    public class HealthHistorySurveyDTO
    {
        public int MaritalStatus { get; set; }
        public bool IsHasADiabetes { get; set; }
        public bool IsHasAHeartDisease { get; set; }
        public bool IsHasAKidneyDisease { get; set; }
        public bool IsHasADepression { get; set; }
        public bool IsHasASexuallyTransmittedDiseases { get; set; }
        public string OtherDisease { get; set; } = string.Empty;
        public int LastPhysicalExamination { get; set; }
        public string Surgeries { get; set; }
        public string Comment { get; set; }
        public string UserId { get; set; }
    }
}
