namespace BloodDonation.Data.Enums
{
    public enum  PhysicalExamination
    {
        [Attributes.DisplayName("Less than a month ago")]
         LessThanMonth=1,

        [Attributes.DisplayName("A month ago")]
        Month,
        
        [Attributes.DisplayName("6 months ago")]
        SixMonthAgo,

        [Attributes.DisplayName("A year ago")]
        Year,

        [Attributes.DisplayName("More than a year ago")]
        MoreThanYear,

        [Attributes.DisplayName("Never")]
        Never,
    }
}
