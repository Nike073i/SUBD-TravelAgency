using System;
using System.ComponentModel;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class SaleDocumentViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО клиента")]
        public string ClientFIO { get; set; }
        [DisplayName("К.Номер клиента")]
        public string ClientContactNumber { get; set; }
        [DisplayName("Название тура")]
        public string TourName { get; set; }
        [DisplayName("Стоимость тура")]
        public decimal TourCost { get; set; }
        [DisplayName("Дата начала тура")]
        public DateTime TourDateOfBegininng { get; set; }
        [DisplayName("Продолжительность тура")]
        public int TourNumberOfDays { get; set; }
        [DisplayName("Количество взрослых")]
        public int TourNumberOfPeople { get; set; }
        [DisplayName("Отель ID")]
        public int TourHotelId { get; set; }
        [DisplayName("Дата публикации тура")]
        public DateTime PublicationDate { get; set; }
        [DisplayName("Дата продажи")]
        public DateTime DateOfSale { get; set; }
    }
}
