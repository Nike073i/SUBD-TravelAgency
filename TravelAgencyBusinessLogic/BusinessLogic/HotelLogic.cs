using System;
using System.Collections.Generic;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogic
{
    public class HotelLogic
    {
        private readonly IHotelStorage _hotelStorage;
        public HotelLogic(IHotelStorage hotelStorage)
        {
            _hotelStorage = hotelStorage;
        }
        public List<HotelViewModel> Read(HotelBindingModel model)
        {
            if (model == null)
            {
                return _hotelStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<HotelViewModel> { _hotelStorage.GetElement(model) };
            }
            return _hotelStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(HotelBindingModel model)
        {
            var hotel = _hotelStorage.GetElement(new HotelBindingModel
            {
                Name = model.Name,
            });
            if (hotel != null && hotel.Id != model.Id)
            {
                throw new Exception("Уже есть отель с таким названием");
            }
            if (model.Id.HasValue)
            {
                _hotelStorage.Update(model);
            }
            else
            {
                _hotelStorage.Insert(model);
            }
        }
        public void Delete(HotelBindingModel model)
        {
            var hotel = _hotelStorage.GetElement(new HotelBindingModel
            {
                Id = model.Id
            });
            if (hotel == null)
            {
                throw new Exception("Отель не найдена");
            }
            _hotelStorage.Delete(model);
        }
    }
}
