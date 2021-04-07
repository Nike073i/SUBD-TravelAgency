using System.ComponentModel;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class CountryViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Официальный язык")]
        public string Language { get; set; }
    }
}
