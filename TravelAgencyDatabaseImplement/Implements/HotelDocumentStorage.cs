using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyDatabaseImplement.DatabaseContext;

namespace TravelAgencyDatabaseImplement.Implements
{
    public class HotelDocumentStorage : IHotelDocumentStorage
    {
        public HotelDocumentViewModel GetElement(HotelDocumentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                var hotel = context.Hotel.Include(rec => rec.Country)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return hotel != null ?
                new HotelDocumentViewModel
                {
                    Id = hotel.Id,
                    Name = hotel.Name,
                    Rating = (int)hotel.Rating,
                    CountryName = hotel.Country.Name,
                    CountryLanguage = hotel.Country.Language,
                    Address = hotel.Address,
                    ContactNumber = hotel.Contactnumber
                } : null;
            }
        }

        public List<HotelDocumentViewModel> GetFilteredList(HotelDocumentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                return context.Hotel.Include(rec => rec.Country)
                .Where(rec => rec.Name == model.Name)
                .Select(rec => new HotelDocumentViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Rating = (int)rec.Rating,
                    CountryName = rec.Country.Name,
                    CountryLanguage = rec.Country.Language,
                    Address = rec.Address,
                    ContactNumber = rec.Contactnumber
                }).ToList();
            }
        }

        public List<HotelDocumentViewModel> GetFullList()
        {
            using (var context = new TravelAgencyDatabase())
            {
                return context.Hotel.Include(rec => rec.Country)
                .Select(rec => new HotelDocumentViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Rating = (int)rec.Rating,
                    CountryName = rec.Country.Name,
                    CountryLanguage = rec.Country.Language,
                    Address = rec.Address,
                    ContactNumber = rec.Contactnumber
                }).ToList();
            }
        }
    }
}
