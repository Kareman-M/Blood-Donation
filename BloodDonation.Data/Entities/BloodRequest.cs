using BloodDonation.Data.Enums;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonation.Data.Entities
{
    public class BloodRequest
    {
        [Key]
        public int Id { get; set; }
        public int RequestedQuantity { get; set; }
        public int RemainQuantity { get; set; }
        public RequestStatus Status { get; set; }
        public string HospitalLocation { get; set; }
        public Guid RequesterUserId {  get; set; }
        [ForeignKey(nameof(RequesterUserId))]
        public User User { get; set; }
        public Collection<BloodRequestDonor> BloodRequestDonors { get; set; }
    }
}
