using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;


namespace TravelAgencyBusinessLogic.BusinessLogic
{
    public class HotelDocumentLogic
    {
        private readonly IHotelDocumentStorageRedis hotelDocumentStorageRedis;
        private readonly IHotelDocumentStorage hotelDocumentStorage;
        public HotelDocumentLogic(IHotelDocumentStorageRedis hotelDocumentStorageRedis, IHotelDocumentStorage hotelDocumentStorage)
        {
            this.hotelDocumentStorageRedis = hotelDocumentStorageRedis;
            this.hotelDocumentStorage = hotelDocumentStorage;
        }
        public List<HotelDocumentViewModel> Read(HotelDocumentBindingModel model)
        {
            if (model == null)
            {
                var redisStorage = hotelDocumentStorageRedis.GetFullList();
                if (redisStorage != null && redisStorage.Count > 0)
                {
                    return redisStorage;
                }
                return hotelDocumentStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                var redisStorage = hotelDocumentStorageRedis.GetElement(model);
                if (redisStorage != null)
                {
                    return new List<HotelDocumentViewModel> { redisStorage };
                }
                return new List<HotelDocumentViewModel> { hotelDocumentStorage.GetElement(model) };
            }
            var redis = hotelDocumentStorageRedis.GetFilteredList(model);
            if (redis != null && redis.Count > 0)
            {
                return redis;
            }
            return hotelDocumentStorage.GetFilteredList(model);
        }
        public void UpdateCashe()
        {
            hotelDocumentStorageRedis.DeleteAll();
            var pgsql = hotelDocumentStorage.GetFullList();
            foreach (var hotel in pgsql)
            {
                hotelDocumentStorageRedis.InsertOrUpdate(new HotelDocumentBindingModel
                {
                    Id = hotel.Id,
                    Name = hotel.Name,
                    Rating = hotel.Rating,
                    CountryName = hotel.CountryName,
                    CountryLanguage = hotel.CountryLanguage,
                    Address = hotel.Address,
                    ContactNumber = hotel.ContactNumber
                });
            }
        }
    }
}
