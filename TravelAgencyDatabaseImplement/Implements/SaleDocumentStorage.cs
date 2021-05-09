using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyDatabaseImplement.DatabaseContext;

namespace TravelAgencyDatabaseImplement.Implements
{
    public class SaleDocumentStorage : ISaleDocumentStorage
    {
        public SaleDocumentViewModel GetElement(SaleDocumentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                var sale = context.Sale.Include(rec => rec.Client).Include(rec => rec.Tour)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return sale != null ?
                new SaleDocumentViewModel
                {
                    Id = sale.Id,
                    ClientFIO = sale.Client.Fio,
                    ClientContactNumber = sale.Client.Contactnumber,
                    TourName = sale.Tour.Name,
                    TourCost = sale.Tour.Cost,
                    TourDateOfBegininng = sale.Tour.Dateofbegininng,
                    TourNumberOfPeople = sale.Tour.Numberofpeople,
                    TourNumberOfDays = sale.Tour.Numberofdays,
                    TourHotelId = sale.Tour.Hotelid,
                    PublicationDate = sale.Tour.Publicationdate,
                    DateOfSale = sale.Dateofsale
                } : null;
            }
        }

        public List<SaleDocumentViewModel> GetFilteredList(SaleDocumentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyDatabase())
            {
                return context.Sale.Include(rec => rec.Client).Include(rec => rec.Tour)
                .Where(rec => rec.Client.Fio == model.ClientFIO)
                .Select(rec => new SaleDocumentViewModel
                {
                    Id = rec.Id,
                    ClientFIO = rec.Client.Fio,
                    ClientContactNumber = rec.Client.Contactnumber,
                    TourName = rec.Tour.Name,
                    TourCost = rec.Tour.Cost,
                    TourDateOfBegininng = rec.Tour.Dateofbegininng,
                    TourNumberOfPeople = rec.Tour.Numberofpeople,
                    TourNumberOfDays = rec.Tour.Numberofdays,
                    TourHotelId = rec.Tour.Hotelid,
                    PublicationDate = rec.Tour.Publicationdate,
                    DateOfSale = rec.Dateofsale
                }).ToList();
            }
        }

        public List<SaleDocumentViewModel> GetFullList()
        {
            using (var context = new TravelAgencyDatabase())
            {
                return context.Sale.Include(rec => rec.Client).Include(rec => rec.Tour)
                .Select(rec => new SaleDocumentViewModel
                {
                    Id = rec.Id,
                    ClientFIO = rec.Client.Fio,
                    ClientContactNumber = rec.Client.Contactnumber,
                    TourName = rec.Tour.Name,
                    TourCost = rec.Tour.Cost,
                    TourDateOfBegininng = rec.Tour.Dateofbegininng,
                    TourNumberOfPeople = rec.Tour.Numberofpeople,
                    TourNumberOfDays = rec.Tour.Numberofdays,
                    TourHotelId = rec.Tour.Hotelid,
                    PublicationDate = rec.Tour.Publicationdate,
                    DateOfSale = rec.Dateofsale
                }).ToList();
            }
        }
    }
}
