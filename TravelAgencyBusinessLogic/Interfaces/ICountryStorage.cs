using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface ICountryStorage
    {
        List<CountryViewModel> GetFullList();
        List<CountryViewModel> GetFilteredList(CountryBindingModel model);
        CountryViewModel GetElement(CountryBindingModel model);
        void Insert(CountryBindingModel model);
        void Update(CountryBindingModel model);
        void Delete(CountryBindingModel model);
    }
}
