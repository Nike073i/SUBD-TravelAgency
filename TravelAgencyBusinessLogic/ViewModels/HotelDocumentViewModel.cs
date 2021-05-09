using System.ComponentModel;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class HotelDocumentViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Рейтинг")]
        public int Rating { get; set; }
        [DisplayName("Название страны")]
        public string CountryName { get; set; }
        [DisplayName("Язык страны")]
        public string CountryLanguage { get; set; }
        [DisplayName("Адрес")]
        public string Address { get; set; }
        [DisplayName("К.Номер")]
        public string ContactNumber { get; set; }
    }
}
