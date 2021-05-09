using Newtonsoft.Json;
using StackExchange.Redis;
using System.Collections.Generic;
using System.Linq;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyDatabaseImplement.RedisImplements
{
    public class SaleDocumentStorageRedis : ISaleDocumentStorageRedis
    {
        public void DeleteAll()
        {
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                var keys = client.GetServer("localhost", 6379).Keys(pattern: "Hotel_*");
                foreach (var key in keys)
                {
                    db.KeyDelete(key);
                }
            }
        }

        public SaleDocumentViewModel GetElement(SaleDocumentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            string result;
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                result = db.StringGet("Sale_" + model.Id.Value.ToString());
            }
            return CreateModel(result);
        }

        public List<SaleDocumentViewModel> GetFilteredList(SaleDocumentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var list = new List<SaleDocumentViewModel>();
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                var keys = client.GetServer("localhost", 6379).Keys(pattern: "Sale_*");
                var keysArr = keys.Select(key => (string)key).ToList();

                foreach (var key in keysArr)
                {
                    var saleJson = db.StringGet(key);
                    var sale = JsonConvert.DeserializeObject<SaleDocumentViewModel>(saleJson);
                    if (sale.ClientFIO == model.ClientFIO)
                    {
                        list.Add(sale);
                    }
                }
            }
            return list;
        }

        public List<SaleDocumentViewModel> GetFullList()
        {
            var list = new List<SaleDocumentViewModel>();
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                var keys = client.GetServer("localhost", 6379).Keys(pattern: "Sale_*");
                var keysArr = keys.Select(key => (string)key).ToList();
                foreach (var key in keysArr)
                {
                    var json = db.StringGet(key);
                    list.Add(CreateModel(json));
                }
            }
            return list;
        }

        public void InsertOrUpdate(SaleDocumentBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                db.StringSet("Sale_" + model.Id.Value.ToString(), JsonConvert.SerializeObject(model));
            }
        }

        private SaleDocumentViewModel CreateModel(string json)
        {
            if (json == null)
            {
                return null;
            }
            var result = JsonConvert.DeserializeObject<SaleDocumentViewModel>(json);
            return result;
        }
    }
}
