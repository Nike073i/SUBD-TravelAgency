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
    public class SaleStorage : ISaleStorage
    {
        public List<SaleViewModel> GetFullList()
        {
            using (var context = new TravelAgencyDatabase())
            {
                return context.Sale
                .Include(rec => rec.Client)
                .Include(rec => rec.Tour)
                .Select(rec => new SaleViewModel
                {
                    Id = rec.Id,
                    TourId = rec.Tourid,
                    TourName = rec.Tour.Name,
                    ClientId = rec.Clientid,
                    ClientFIO = String.Concat(rec.Client.Secondname, " ", rec.Client.Firstname, " ", rec.Client.Middlename),
                    DateOfSale = rec.Dateofsale
                }).ToList();
            }
        }
        public List<SaleViewModel> GetFilteredList(SaleBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                return context.Sale
                .Include(rec => rec.Client)
                .Include(rec => rec.Tour)
                .Where(rec => rec.Clientid.Equals(model.ClientId))
                .Select(rec => new SaleViewModel
                {
                    Id = rec.Id,
                    TourId = rec.Tourid,
                    TourName = rec.Tour.Name,
                    ClientId = rec.Clientid,
                    ClientFIO = String.Concat(rec.Client.Secondname, " ", rec.Client.Firstname, " ", rec.Client.Middlename),
                    DateOfSale = rec.Dateofsale
                }).ToList();
            }
        }
        public SaleViewModel GetElement(SaleBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                var sale = context.Sale
                    .Include(rec => rec.Client)
                    .Include(rec => rec.Tour)
                    .FirstOrDefault(rec => rec.Id == model.Id);
                return sale != null ?
                new SaleViewModel
                {
                    Id = sale.Id,
                    TourId = sale.Tourid,
                    TourName = sale.Tour.Name,
                    ClientId = sale.Clientid,
                    ClientFIO = String.Concat(sale.Client.Secondname, " ", sale.Client.Firstname, " ", sale.Client.Middlename),
                    DateOfSale = sale.Dateofsale
                } : null;
            }
        }
        public void Insert(SaleBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                context.Sale.Add(CreateModel(model, new Sale()));
                context.SaveChanges();
            }
        }
        public void Update(SaleBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                var sale = context.Sale.FirstOrDefault(rec => rec.Id == model.Id);
                if (sale == null)
                {
                    throw new Exception("Продажа не найден");
                }
                CreateModel(model, sale);
                context.SaveChanges();
            }
        }
        public void Delete(SaleBindingModel model)
        {
            using (var context = new TravelAgencyDatabase())
            {
                Sale sale = context.Sale.FirstOrDefault(rec => rec.Id == model.Id);
                if (sale != null)
                {
                    context.Sale.Remove(sale);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Продажа не найден");
                }
            }
        }
        private Sale CreateModel(SaleBindingModel model, Sale sale)
        {
            sale.Clientid = model.ClientId;
            sale.Tourid = model.TourId;
            sale.Dateofsale = model.DateOfSale;
            return sale;
        }
    }
}
