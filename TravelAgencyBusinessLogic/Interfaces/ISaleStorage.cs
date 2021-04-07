using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface ISaleStorage
    {
        List<SaleViewModel> GetFullList();
        List<SaleViewModel> GetFilteredList(SaleBindingModel model);
        SaleViewModel GetElement(SaleBindingModel model);
        void Insert(SaleBindingModel model);
        void Update(SaleBindingModel model);
        void Delete(SaleBindingModel model);
    }
}
