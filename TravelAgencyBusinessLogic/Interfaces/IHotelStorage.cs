using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface IHotelStorage
    {
        List<HotelViewModel> GetFullList();
        List<HotelViewModel> GetFilteredList(HotelBindingModel model);
        HotelViewModel GetElement(HotelBindingModel model);
        void Insert(HotelBindingModel model);
        void Update(HotelBindingModel model);
        void Delete(HotelBindingModel model);
    }
}
