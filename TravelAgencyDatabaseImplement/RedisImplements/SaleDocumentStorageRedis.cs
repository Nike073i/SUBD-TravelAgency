using Newtonsoft.Json;
using StackExchange.Redis;
using System.Collections.Generic;
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
                var sales = db.SetMembers("Sale");
                db.SetRemove("Sale", sales);
            }
        }

        public SaleDocumentViewModel GetElement(SaleDocumentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var client = ConnectionMultiplexer.Connect("localhost"))
            {
                var db = client.GetDatabase();
                var sales = db.SetMembers("Sale");
                foreach (var key in sales)
                {
                    var sale = JsonConvert.DeserializeObject<SaleDocumentViewModel>(key);
                    if (sale.Id == model.Id)
                    {
                        return sale;
                    }
                }
            }
            return null;
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
                var sales = db.SetMembers("Sale");
                foreach (var key in sales)
                {
                    var sale = JsonConvert.DeserializeObject<SaleDocumentViewModel>(key);
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
                var sales = db.SetMembers("Sale");
                foreach (var key in sales)
                {
                    list.Add(CreateModel(key));
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
                db.SetAdd("Sale", JsonConvert.SerializeObject(model));
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
