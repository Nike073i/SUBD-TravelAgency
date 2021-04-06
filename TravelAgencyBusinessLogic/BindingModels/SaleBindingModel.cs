using System;

namespace TravelAgencyBusinessLogic.BindingModels
{
    public class SaleBindingModel
    {
        public int? Id { get; set; }
        public int TourId { get; set; }
        public int ClientId { get; set; }
        public DateTime DateOfSale { get; set; }
    }
}
