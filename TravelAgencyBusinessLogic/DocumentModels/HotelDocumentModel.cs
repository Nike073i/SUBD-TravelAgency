using MongoDB.Bson;

namespace TravelAgencyBusinessLogic.DocumentModels
{
    public class Country
    {
        public string Name { get; set; }
        public string Language { get; set; }
    }

    public class HotelDocumentModel
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public Country Country { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
    }
}
