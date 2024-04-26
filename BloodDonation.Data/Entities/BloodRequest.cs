using BloodDonation.Data.Enums;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonation.Data.Entities
{
    public class BloodRequest:BaseEntity
    {
        [Required]
        public int RequestedQuantity { get; set; }
        [Required]
        public int RemainQuantity { get; set; }
        [Required]
        public RequestStatus Status { get; set; }
        [Required]
        public string HospitalLocation { get; set; }
        [Required]
        public string RequesterUserId {  get; set; }
        [ForeignKey(nameof(RequesterUserId))]
        public User User { get; set; }
        public Collection<BloodRequestDonor> BloodRequestDonors { get; set; }
        private BloodRequest()
        {

        }
    }
}
