namespace Core.Entities
{
    public class Package : BaseEntity
    {
        public Package(string trackingCode, string fullAdress, decimal weightInKg, DateTime postedAt, string description)
        {
            TrackingCode = trackingCode;
            FullAdress = fullAdress;
            WeightInKg = weightInKg;
            PostedAt = postedAt;
            Description = description;
        }

        public string TrackingCode { get; private set; }
        public string FullAdress { get; private set; }
        public decimal WeightInKg { get; private set; }
        public DateTime PostedAt { get; private set; }
        public string Description { get; private set; }
    }
}
