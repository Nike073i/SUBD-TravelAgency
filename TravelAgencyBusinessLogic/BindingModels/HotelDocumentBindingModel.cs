using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.BindingModels
{
    public class HotelDocumentBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string CountryName { get; set; }
        public string CountryLanguage { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
    }
}
