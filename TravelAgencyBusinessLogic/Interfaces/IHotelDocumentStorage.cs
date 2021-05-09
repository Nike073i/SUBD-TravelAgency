﻿using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface IHotelDocumentStorage
    {
        HotelDocumentViewModel GetElement(HotelDocumentBindingModel model);
        List<HotelDocumentViewModel> GetFilteredList(HotelDocumentBindingModel model);
        List<HotelDocumentViewModel> GetFullList();
    }
}
