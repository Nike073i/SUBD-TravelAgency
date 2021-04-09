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
    public class CountryStorage : ICountryStorage
    {
        public List<CountryViewModel> GetFullList()
        {
            using (var context = new TravelAgencyDatabase())
            {
                return context.Country
                .Select(rec => new CountryViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Language = rec.Language
                }).ToList();
            }
        }
        public List<CountryViewModel> GetFilteredList(CountryBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                return context.Country
                .Where(rec => rec.Name.Contains(model.Name))
               .Select(rec => new CountryViewModel
               {
                   Id = rec.Id,
                   Name = rec.Name,
                   Language = rec.Language
               }).ToList();
            }
        }
        public CountryViewModel GetElement(CountryBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                var country = context.Country
                .FirstOrDefault(rec => rec.Name.Equals(model.Name) || rec.Id == model.Id);
                return country != null ?
                new CountryViewModel
                {
                    Id = country.Id,
                    Name = country.Name,
                    Language = country.Language
                } : null;
            }
        }
        public void Insert(CountryBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                context.Country.Add(CreateModel(model, new Country()));
                context.SaveChanges();
            }
        }
        public void Update(CountryBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                var country = context.Country.FirstOrDefault(rec => rec.Id == model.Id);
                if (country == null)
                {
                    throw new Exception("Страна не найдена");
                }
                CreateModel(model, country);
                context.SaveChanges();
            }
        }
        public void Delete(CountryBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                Country country = context.Country.FirstOrDefault(rec => rec.Id == model.Id);
                if (country != null)
                {
                    context.Country.Remove(country);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Страна не найдена");
                }
            }
        }
        private Country CreateModel(CountryBindingModel model, Country client)
        {
            client.Name = model.Name;
            client.Language = model.Language;
            return client;
        }
    }
}
