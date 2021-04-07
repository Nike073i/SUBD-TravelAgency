using System;
using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogic
{
    public class SaleLogic
    {
        private readonly ISaleStorage _saleStorage;
        public SaleLogic(ISaleStorage saleStorage)
        {
            _saleStorage = saleStorage;
        }
        public List<SaleViewModel> Read(SaleBindingModel model)
        {
            if (model == null)
            {
                return _saleStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<SaleViewModel> { _saleStorage.GetElement(model) };
            }
            return _saleStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(SaleBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _saleStorage.Update(model);
            }
            else
            {
                _saleStorage.Insert(model);
            }
        }
        public void Delete(SaleBindingModel model)
        {
            var sale = _saleStorage.GetElement(new SaleBindingModel
            {
                Id = model.Id
            });
            if (sale == null)
            {
                throw new Exception("Продажа не найдена");
            }
            _saleStorage.Delete(model);
        }
    }
}
