using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface ISaleDocumentStorage
    {
        SaleDocumentViewModel GetElement(SaleDocumentBindingModel model);
        List<SaleDocumentViewModel> GetFilteredList(SaleDocumentBindingModel model);
        List<SaleDocumentViewModel> GetFullList();
    }
}
