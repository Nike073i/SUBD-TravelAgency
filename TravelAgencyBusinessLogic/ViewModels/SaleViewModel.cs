using System;
using System.ComponentModel;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class SaleViewModel
    {
        public int Id { get; set; }
        public int TourId { get; set; }

        [DisplayName("Тур")]
        public string TourName { get; set; }
        public int ClientId { get; set; }

        [DisplayName("Клиент")]
        public string ClientFIO { get; set; }

        [DisplayName("Дата продажи")]
        public DateTime DateOfSale { get; set; }
    }
}
