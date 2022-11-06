using Core.Entities;
using MongoDB.Driver;

namespace Infrastructure
{
    public class DatabaseSeed
    {
        private readonly IMongoCollection<Shipping> _dbCollection;

        private IEnumerable<Shipping> _shippings = new List<Shipping>
        {
            new Shipping("Sedex", 3.75m, 12),
            new Shipping("PAC", 2.75m, 8),
            new Shipping("Amazon", 5.00m, 20),
        };

        public DatabaseSeed(IMongoDatabase db)
        {
            _dbCollection = db.GetCollection<Shipping>("shipping");
        }

        public void Populate()
        {
            if (_dbCollection.CountDocuments(x => true) == 0)
                _dbCollection.InsertMany(_shippings);
        }
    }
}
