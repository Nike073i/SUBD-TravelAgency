using System.Threading.Tasks;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.DocumentModels;
using TravelAgencyBusinessLogic.Interfaces;

namespace TravelAgencyBusinessLogic.BusinessLogic
{
    public class TransferLogic
    {
        private readonly IClientStorage clientStorage;
        private readonly ICountryStorage countryStorage;
        private readonly IHotelStorage hotelStorage;
        private readonly ISaleStorage saleStorage;
        private readonly ITourStorage tourStorage;

        public TransferLogic(IClientStorage clientStorage, ICountryStorage countryStorage, IHotelStorage hotelStorage, ISaleStorage saleStorage, ITourStorage tourStorage)
        {
            this.clientStorage = clientStorage;
            this.countryStorage = countryStorage;
            this.hotelStorage = hotelStorage;
            this.saleStorage = saleStorage;
            this.tourStorage = tourStorage;
        }
        public async void TransferAll()
        {
            var hotels = hotelStorage.GetFullList();
            var sales = saleStorage.GetFullList();

            await Task.Run(async () =>
            {
                foreach (var hotel in hotels)
                {
                    var country = countryStorage.GetElement(new CountryBindingModel { Id = hotel.CountryId });
                    await DbTransferToMongo.SaveHotel(new HotelDocumentModel
                    {
                        Name = hotel.Name,
                        Rating = (int)hotel.Rating,
                        Country = new Country
                        {
                            Name = country.Name,
                            Language = country.Language
                        },
                        Address = hotel.Address,
                        ContactNumber = hotel.ContactNumber
                    });
                }
            });

            await Task.Run(async () =>
            {
                foreach (var sale in sales)
                {
                    var client = clientStorage.GetElement(new ClientBindingModel { Id = sale.ClientId });
                    var tour = tourStorage.GetElement(new TourBindingModel { Id = sale.TourId });

                    var hotelId = await DbTransferToMongo.FindHotel(new HotelDocumentModel { Name = tour.HotelName });
                    await DbTransferToMongo.SaveSale(new SaleDocumentModel
                    {
                        Client = new Client
                        {
                            FIO = client.FIO,
                            ContactNumber = client.ContactNumber
                        },
                        Tour = new Tour
                        {
                            Name = tour.Name,
                            Cost = tour.Cost,
                            DateOfBegininng = tour.DateOfBegininng,
                            NumberOfDays = tour.NumberOfDays,
                            NumberOfPeople = tour.NumberOfPeople,
                            HotelId = hotelId,
                            PublicationDate = tour.PublicationDate
                        },
                        DateOfSale = sale.DateOfSale
                    });
                }
            });
        }
    }
}
