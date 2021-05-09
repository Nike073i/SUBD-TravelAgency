using Newtonsoft.Json;
using StackExchange.Redis;
using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyDatabaseImplement.RedisImplements
{
    public class HotelDocumentStorageRedis : IHotelDocumentStorageRedis
    {
        public void DeleteAll()
        {
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                var hotels = db.SetMembers("Hotel");
                db.SetRemove("Hotel", hotels);
            }
        }

        public HotelDocumentViewModel GetElement(HotelDocumentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                var hotels = db.SetMembers("Hotel");
                foreach (var key in hotels)
                {
                    var hotel = JsonConvert.DeserializeObject<HotelDocumentViewModel>(key);
                    if (hotel.Id == model.Id)
                    {
                        return hotel;
                    }
                }
            }
            return null;
        }

        public List<HotelDocumentViewModel> GetFilteredList(HotelDocumentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var list = new List<HotelDocumentViewModel>();
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                var hotels = db.SetMembers("Hotel");
                foreach (var key in hotels)
                {
                    var hotel = JsonConvert.DeserializeObject<HotelDocumentViewModel>(key);
                    if (hotel.Name == model.Name)
                    {
                        list.Add(hotel);
                    }
                }
            }
            return list;
        }

        public List<HotelDocumentViewModel> GetFullList()
        {
            var list = new List<HotelDocumentViewModel>();
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                var hotels = db.SetMembers("Hotel");
                foreach (var key in hotels)
                {
                    list.Add(CreateModel(key));
                }
            }
            return list;
        }

        public void InsertOrUpdate(HotelDocumentBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                db.SetAdd("Hotel", JsonConvert.SerializeObject(model));
            }
        }

        private HotelDocumentViewModel CreateModel(string json)
        {
            if (json == null)
            {
                return null;
            }
            var result = JsonConvert.DeserializeObject<HotelDocumentViewModel>(json);
            return result;
        }
    }
}
