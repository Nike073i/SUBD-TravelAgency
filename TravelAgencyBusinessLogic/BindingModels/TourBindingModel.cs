using System;

namespace TravelAgencyBusinessLogic.BindingModels
{
    public class TourBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateOfBegininng { get; set; }
        public int NumberOfDays { get; set; }
        public int NumberOfPeople { get; set; }
        public int HotelId { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
