using System;
using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogic
{
    public class CountryLogic
    {
        private readonly ICountryStorage _countryStorage;
        public CountryLogic(ICountryStorage countryStorage)
        {
            _countryStorage = countryStorage;
        }
        public List<CountryViewModel> Read(CountryBindingModel model)
        {
            if (model == null)
            {
                return _countryStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<CountryViewModel> { _countryStorage.GetElement(model) };
            }
            return _countryStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(CountryBindingModel model)
        {
            var country = _countryStorage.GetElement(new CountryBindingModel
            {
                Name = model.Name
            });
            if (country != null && country.Id != model.Id)
            {
                throw new Exception("Уже есть страна с таким названием");
            }
            if (model.Id.HasValue)
            {
                _countryStorage.Update(model);
            }
            else
            {
                _countryStorage.Insert(model);
            }
        }
        public void Delete(CountryBindingModel model)
        {
            var country = _countryStorage.GetElement(new CountryBindingModel
            {
                Id = model.Id
            });
            if (country == null)
            {
                throw new Exception("Страна не найдена");
            }
            _countryStorage.Delete(model);
        }
    }
}
