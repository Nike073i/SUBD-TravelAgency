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
    public class TourStorage : ITourStorage
    {
        public List<TourViewModel> GetFullList()
        {
            using (var context = new TravelAgencyDatabase())
            {
                return context.Tour
                .Include(rec => rec.Hotel)
                .Select(rec => new TourViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Cost = rec.Cost,
                    DateOfBegininng = rec.Dateofbegininng,
                    NumberOfDays = rec.Numberofdays,
                    NumberOfPeople = rec.Numberofpeople,
                    HotelId = rec.Hotelid,
                    HotelName = rec.Hotel.Name,
                    PublicationDate = rec.Publicationdate
                }).ToList();
            }
        }
        public List<TourViewModel> GetFilteredList(TourBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                return context.Tour
                .Include(rec => rec.Hotel)
                .Where(rec => (!model.CostFrom.HasValue && !model.CostTo.HasValue && rec.Cost == model.Cost)
                    || (model.CostFrom.HasValue && model.CostTo.HasValue && rec.Cost >= model.CostFrom.Value && rec.Cost <= model.CostTo.Value))
                .Select(rec => new TourViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Cost = rec.Cost,
                    DateOfBegininng = rec.Dateofbegininng,
                    NumberOfDays = rec.Numberofdays,
                    NumberOfPeople = rec.Numberofpeople,
                    HotelId = rec.Hotelid,
                    HotelName = rec.Hotel.Name,
                    PublicationDate = rec.Publicationdate
                }).ToList();
            }
        }
        public TourViewModel GetElement(TourBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                var tour = context.Tour
                    .Include(rec => rec.Hotel)
                    .FirstOrDefault(rec => rec.Name.Equals(model.Name) || rec.Id == model.Id);
                return tour != null ?
                new TourViewModel
                {
                    Id = tour.Id,
                    Name = tour.Name,
                    Cost = tour.Cost,
                    DateOfBegininng = tour.Dateofbegininng,
                    NumberOfDays = tour.Numberofdays,
                    NumberOfPeople = tour.Numberofpeople,
                    HotelId = tour.Hotelid,
                    HotelName = tour.Hotel.Name,
                    PublicationDate = tour.Publicationdate
                } : null;
            }
        }
        public void Insert(TourBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                context.Tour.Add(CreateModel(model, new Tour()));
                context.SaveChanges();
            }
        }
        public void Update(TourBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                var tour = context.Tour.FirstOrDefault(rec => rec.Id == model.Id);
                if (tour == null)
                {
                    throw new Exception("Тур не найден");
                }
                CreateModel(model, tour);
                context.SaveChanges();
            }
        }
        public void Delete(TourBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                Tour tour = context.Tour.FirstOrDefault(rec => rec.Id == model.Id);
                if (tour != null)
                {
                    context.Tour.Remove(tour);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Тур не найден");
                }
            }
        }
        private Tour CreateModel(TourBindingModel model, Tour tour)
        {
            tour.Name = model.Name;
            tour.Cost = model.Cost;
            tour.Dateofbegininng = model.DateOfBegininng;
            tour.Numberofdays = model.NumberOfDays;
            tour.Numberofpeople = model.NumberOfPeople;
            tour.Hotelid = model.HotelId;
            tour.Publicationdate = model.PublicationDate;
            return tour;
        }
    }
}
