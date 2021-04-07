using System.ComponentModel;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [DisplayName("Фамилия")]
        public string SecondName { get; set; }

        [DisplayName("Отчество")]
        public string MiddleName { get; set; }

        [DisplayName("Номер телефона")]
        public string ContactNumber { get; set; }
    }
}
