using System;
using System.ComponentModel;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class TourViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Стоимость")]
        public decimal Cost { get; set; }

        [DisplayName("Дата начала")]
        public DateTime DateOfBegininng { get; set; }

        [DisplayName("Количество дней")]
        public int NumberOfDays { get; set; }

        [DisplayName("Количество людей")]
        public int NumberOfPeople { get; set; }
        public int HotelId { get; set; }

        [DisplayName("Отель")]
        public string HotelName { get; set; }

        [DisplayName("Дата публикации")]
        public DateTime PublicationDate { get; set; }
    }
}
