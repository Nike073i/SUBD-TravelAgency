using System.ComponentModel;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class HotelViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Рейтинг")]
        public int? Rating { get; set; }
        public int CountryId { get; set; }

        [DisplayName("Страна")]
        public string CountryName { get; set; }

        [DisplayName("Адрес")]
        public string Address { get; set; }

        [DisplayName("Номер телефона")]
        public string ContactNumber { get; set; }
    }
}
