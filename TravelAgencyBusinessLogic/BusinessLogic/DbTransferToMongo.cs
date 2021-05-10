using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using TravelAgencyBusinessLogic.DocumentModels;

namespace TravelAgencyBusinessLogic.BusinessLogic
{
    public class DbTransferToMongo
    {
        static string connectionString = "mongodb://localhost:27017";
        static string DatabaseString = "TravelAgency";
        static string SaleCollectionString = "Sale";
        static string HotelCollectionString = "Hotel";

        public static async Task SaveHotel(HotelDocumentModel model)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(DatabaseString);
            var collection = database.GetCollection<HotelDocumentModel>(HotelCollectionString);
            await collection.InsertOneAsync(model);
        }
        public static async Task SaveSale(SaleDocumentModel model)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(DatabaseString);
            var collection = database.GetCollection<SaleDocumentModel>(SaleCollectionString);
            await collection.InsertOneAsync(model);
        }

        public static async Task<ObjectId> FindHotel(HotelDocumentModel model)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(DatabaseString);
            var collection = database.GetCollection<HotelDocumentModel>(HotelCollectionString);
            var filter = new BsonDocument("Name", model.Name);
            var result = await collection.FindAsync(filter);
            return result.FirstOrDefault().Id;
        }
    }
}
