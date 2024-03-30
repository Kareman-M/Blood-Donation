using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonation.Data.Entities
{
    public class BloodRequestDonor
    {
        [Key]
        public int Id { get; set; }
        public int DonationQuantity { get; set; }
        public int BloodRequestId { get; set; }

        [ForeignKey(nameof(BloodRequestId))]
        public BloodRequest BloodRequest { get; set; }
        public Guid DonorUserId { get; set; }

        [ForeignKey(nameof(DonorUserId))]
        public User User { get; set; }
    }
}
