using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogic
{
    public class SaleDocumentLogic
    {
        private readonly ISaleDocumentStorageRedis saleDocumentStorageRedis;
        private readonly ISaleDocumentStorage saleDocumentStorage;
        public SaleDocumentLogic(ISaleDocumentStorageRedis saleDocumentStorageRedis, ISaleDocumentStorage saleDocumentStorage)
        {
            this.saleDocumentStorageRedis = saleDocumentStorageRedis;
            this.saleDocumentStorage = saleDocumentStorage;
        }
        public List<SaleDocumentViewModel> Read(SaleDocumentBindingModel model)
        {
            if (model == null)
            {
                var redisStorage = saleDocumentStorageRedis.GetFullList();
                if (redisStorage != null && redisStorage.Count > 0)
                {
                    return redisStorage;
                }
                return saleDocumentStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                var redisStorage = saleDocumentStorageRedis.GetElement(model);
                if (redisStorage != null)
                {
                    return new List<SaleDocumentViewModel> { redisStorage };
                }
                return new List<SaleDocumentViewModel> { saleDocumentStorage.GetElement(model) };
            }
            var redis = saleDocumentStorageRedis.GetFilteredList(model);
            if (redis != null && redis.Count > 0)
            {
                return redis;
            }
            return saleDocumentStorage.GetFilteredList(model);
        }
        public void UpdateCashe()
        {
            saleDocumentStorageRedis.DeleteAll();
            var pgsql = saleDocumentStorage.GetFullList();
            foreach (var sale in pgsql)
            {
                saleDocumentStorageRedis.InsertOrUpdate(new SaleDocumentBindingModel
                {
                    Id = sale.Id,
                    ClientFIO = sale.ClientFIO,
                    ClientContactNumber = sale.ClientContactNumber,
                    TourName = sale.TourName,
                    TourCost = sale.TourCost,
                    TourDateOfBegininng = sale.TourDateOfBegininng,
                    TourNumberOfPeople = sale.TourNumberOfPeople,
                    TourNumberOfDays = sale.TourNumberOfDays,
                    TourHotelId = sale.TourHotelId,
                    PublicationDate = sale.PublicationDate,
                    DateOfSale = sale.DateOfSale
                });
            }
        }
    }
}
