using BloodDonation.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonation.Data.Entities
{
    public class HealthHistorySurvey : BaseEntity
    {
        [Required]
        public MaritalStatus MaritalStatus { get; private set; }

        [Required]
        public bool IsHasADiabetes { get; private set; }

        [Required]
        public bool IsHasAHeartDisease { get; private set; }

        [Required]
        public bool IsHasAKidneyDisease { get; private set; }

        [Required]
        public bool IsHasADepression { get; private set; }

        [Required]
        public bool IsHasASexuallyTransmittedDiseases { get; private set; }

        public string OtherDisease { get; private set; } = string.Empty;

        [Required]
        public PhysicalExamination LastPhysicalExamination { get; private set; }
        
        public string Surgeries { get; private set; }
        
        public string Comment { get; private set; }

        [Required]
        public string UserId { get; private set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; private set; }

        private HealthHistorySurvey() { }

        public static HealthHistorySurvey Create(string userId, string? comment, string? surgeries, int lastExamination , string? otherDisease,
            bool isHasASexuallyTransmittedDiseases, bool isHasADepression, bool isHasAKidneyDisease, bool isHasAHeartDisease , bool isHasADiabetes, int maritalStatus)
        {
            CheckEnumRange(lastExamination, maritalStatus);

            return new HealthHistorySurvey
            {
                
                IsHasADepression = isHasADepression,
                IsHasADiabetes = isHasADiabetes,
                IsHasAKidneyDisease = isHasAKidneyDisease,
                IsHasAHeartDisease = isHasAHeartDisease,
                IsHasASexuallyTransmittedDiseases = isHasASexuallyTransmittedDiseases,
                LastPhysicalExamination = (PhysicalExamination)lastExamination,
                MaritalStatus = (MaritalStatus)maritalStatus,
                Surgeries = surgeries,
                OtherDisease = otherDisease,
                UserId = userId,
                Comment= comment,
                Removed = false,
                CreatedBy = userId,
                CreatedAt = DateTime.Now,
            };

        }

        public void Update(string userId, string comment, string surgeries, int lastPhysicalExamination, string otherDisease, bool isHasASexuallyTransmittedDiseases, bool isHasADepression, bool isHasAKidneyDisease, bool isHasAHeartDisease, bool isHasADiabetes, int maritalStatus)
        {
            CheckEnumRange(lastPhysicalExamination, maritalStatus);

            IsHasADepression = isHasADepression;
            IsHasADiabetes = isHasADiabetes;
            IsHasAKidneyDisease = isHasAKidneyDisease;
            IsHasAHeartDisease = isHasAHeartDisease;
            IsHasASexuallyTransmittedDiseases = isHasASexuallyTransmittedDiseases;
            LastPhysicalExamination = (PhysicalExamination)lastPhysicalExamination;
            MaritalStatus = (MaritalStatus)maritalStatus;
            Surgeries = surgeries;
            OtherDisease = otherDisease;
            UserId = userId;
            Comment = comment;
            ModifiedBy = userId;
            ModifiedAt = DateTime.Now;
        }

        private static void CheckEnumRange(int lastExamination , int maritalStatus)
        {

            if (!Enum.GetValues(typeof(PhysicalExamination)).Cast<int>().Any(x => x == lastExamination)) throw new Exception("Physical Examination Is Out Of Range");

            if (!Enum.GetValues(typeof(MaritalStatus)).Cast<int>().Any(x => x == maritalStatus)) throw new Exception("Marital Status Is Out Of Range");


        }
    }
}
