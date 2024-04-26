using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonation.Data.Entities
{
    public class BloodRequestDonor : BaseEntity
    {
        [Required]
        public int DonationQuantity { get; private set; }
        [Required]
        public int BloodRequestId { get; private set; }

        [ForeignKey(nameof(BloodRequestId))]
        public BloodRequest BloodRequest { get; private set; }
        [Required]
        public string DonorUserId { get; private set; }

        [ForeignKey(nameof(DonorUserId))]
        public User User { get; private set; }
        private BloodRequestDonor()
        {

        }

        public static BloodRequestDonor Create(int bloodrequestId, int donationQty, string userId)
        {
            return new BloodRequestDonor()
            {
                DonationQuantity = donationQty,
                BloodRequestId = bloodrequestId,
                DonorUserId = userId,
                CreatedAt = DateTime.Now,
                CreatedBy = userId,
            };
        }

        public void UpdateDonationQty(int donationQty)
        {
            DonationQuantity = donationQty;
        }
    }
}
