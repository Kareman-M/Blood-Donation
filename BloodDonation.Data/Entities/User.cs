using BloodDonation.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonation.Data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Location { get; set; }
        public int HistorySurveyId { get; set; }

        [ForeignKey(nameof(HistorySurveyId))]
        public HistorySurvey HistorySurvey { get; set; }
        public Collection<BloodRequest> BloodRequests { get; set; }
    }
}
