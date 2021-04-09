using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyDatabaseImplement.DatabaseContext;
using TravelAgencyDatabaseImplement.Models;

namespace TravelAgencyDatabaseImplement.Implements
{
    public class HotelStorage : IHotelStorage
    {
        public List<HotelViewModel> GetFullList()
        {
            using (var context = new TravelAgencyDatabase())
            {
                return context.Hotel
                .Include(rec => rec.Country)
                .Select(rec => new HotelViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Rating = rec.Rating.GetValueOrDefault(),
                    CountryId = rec.Countrieid,
                    CountryName = rec.Country.Name,
                    Address = rec.Address,
                    ContactNumber = rec.Contactnumber
                }).ToList();
            }
        }
        public List<HotelViewModel> GetFilteredList(HotelBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                return context.Hotel
                .Include(rec => rec.Country)
                .Where(rec => (!model.RatingFrom.HasValue && !model.RatingTo.HasValue && rec.Rating.HasValue && rec.Rating == model.Rating)
                || (model.RatingFrom.HasValue && model.RatingTo.HasValue && rec.Rating.HasValue && rec.Rating >= model.RatingFrom.Value && rec.Rating <= model.RatingTo.Value))
                .Select(rec => new HotelViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Rating = rec.Rating.GetValueOrDefault(),
                    CountryId = rec.Countrieid,
                    CountryName = rec.Country.Name,
                    Address = rec.Address,
                    ContactNumber = rec.Contactnumber
                }).ToList();
            }
        }
        public HotelViewModel GetElement(HotelBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                var hotel = context.Hotel
                    .Include(rec => rec.Country)
                    .FirstOrDefault(rec => rec.Name.Equals(model.Name) || rec.Id == model.Id);
                return hotel != null ?
                new HotelViewModel
                {
                    Id = hotel.Id,
                    Name = hotel.Name,
                    Rating = hotel.Rating.GetValueOrDefault(),
                    CountryId = hotel.Countrieid,
                    CountryName = hotel.Country.Name,
                    Address = hotel.Address,
                    ContactNumber = hotel.Contactnumber
                } : null;
            }
        }
        public void Insert(HotelBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                context.Hotel.Add(CreateModel(model, new Hotel()));
                context.SaveChanges();
            }
        }
        public void Update(HotelBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                var hotel = context.Hotel.FirstOrDefault(rec => rec.Id == model.Id);
                if (hotel == null)
                {
                    throw new Exception("Отель не найден");
                }
                CreateModel(model, hotel);
                context.SaveChanges();
            }
        }
        public void Delete(HotelBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                Hotel hotel = context.Hotel.FirstOrDefault(rec => rec.Id == model.Id);
                if (hotel != null)
                {
                    context.Hotel.Remove(hotel);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Отель не найден");
                }
            }
        }
        private Hotel CreateModel(HotelBindingModel model, Hotel hotel)
        {
            hotel.Name = model.Name;
            hotel.Rating = model.Rating.GetValueOrDefault();
            hotel.Countrieid = model.CountryId;
            hotel.Address = model.Address;
            hotel.Contactnumber = model.ContactNumber;
            return hotel;
        }
    }
}
