using System.ComponentModel;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        [DisplayName("ФИО")]
        public string FIO { get; set; }

        [DisplayName("Номер телефона")]
        public string ContactNumber { get; set; }
    }
}
