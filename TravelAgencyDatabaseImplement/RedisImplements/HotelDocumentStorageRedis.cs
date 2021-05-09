using Newtonsoft.Json;
using StackExchange.Redis;
using System.Collections.Generic;
using System.Linq;
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
                var keys = client.GetServer("localhost", 6379).Keys(pattern: "Hotel_*");
                foreach(var key in keys)
                {
                    db.KeyDelete(key);
                }
            }
        }

        public HotelDocumentViewModel GetElement(HotelDocumentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            string result;
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                result = db.StringGet("Hotel_" + model.Id.Value.ToString());
            }
            return CreateModel(result);
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
                var keys = client.GetServer("localhost", 6379).Keys(pattern: "Hotel_*");
                var keysArr = keys.Select(key => (string)key).ToList();

                foreach (var key in keysArr)
                {
                    var hotelJson = db.StringGet(key);
                    var hotel = JsonConvert.DeserializeObject<HotelDocumentViewModel>(hotelJson);
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
                var keys = client.GetServer("localhost", 6379).Keys(pattern: "Hotel_*");
                var keysArr = keys.Select(key => (string)key).ToList();
                foreach (var key in keysArr)
                {
                    var json = db.StringGet(key);
                    list.Add(CreateModel(json));
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
                db.StringSet("Hotel_" + model.Id.Value.ToString(), JsonConvert.SerializeObject(model));
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
