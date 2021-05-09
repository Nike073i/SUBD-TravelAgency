using System;

namespace TravelAgencyBusinessLogic.BindingModels
{
    public class SaleDocumentBindingModel
    {
        public int? Id { get; set; }
        public string ClientFIO { get; set; }
        public string ClientContactNumber { get; set; }
        public string TourName { get; set; }
        public decimal TourCost { get; set; }
        public DateTime TourDateOfBegininng { get; set; }
        public int TourNumberOfDays { get; set; }
        public int TourNumberOfPeople { get; set; }
        public int TourHotelId { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime DateOfSale { get; set; }
    }
}
