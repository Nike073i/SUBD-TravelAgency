using MongoDB.Bson;
using System;

namespace TravelAgencyBusinessLogic.DocumentModels
{
    public class Client
    {
        public string FIO { get; set; }
        public string ContactNumber { get; set; }
    }
    public class Tour
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateOfBegininng { get; set; }
        public int NumberOfDays { get; set; }
        public int NumberOfPeople { get; set; }
        public ObjectId HotelId { get; set; }
        public DateTime PublicationDate { get; set; }
    }

    public class SaleDocumentModel
    {
        public ObjectId Id { get; set; }
        public Client Client { get; set; }
        public Tour Tour { get; set; }
        public DateTime DateOfSale { get; set; }
    }
}
