namespace Core.Entities
{
    public class Shipping : BaseEntity
    {
        public Shipping(string title, decimal pricePerKg, decimal fixedPrice)
        {
            Title = title;
            PricePerKg = pricePerKg;
            FixedPrice = fixedPrice;
        }

        public string Title { get; private set; }
        public decimal PricePerKg { get; private set; }
        public decimal FixedPrice { get; private set; }
    }
}
