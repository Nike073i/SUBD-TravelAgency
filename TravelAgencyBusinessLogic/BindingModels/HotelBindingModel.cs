namespace TravelAgencyBusinessLogic.BindingModels
{
    public class HotelBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? Rating { get; set; }
        public int CountryId { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public int? RatingFrom { get; set; }
        public int? RatingTo { get; set; }
    }
}
