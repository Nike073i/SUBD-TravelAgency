using System;
using System.Collections.Generic;

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            Tour = new HashSet<Tour>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Rating { get; set; }
        public int Countrieid { get; set; }
        public string Address { get; set; }
        public string Contactnumber { get; set; }

        public virtual Country Countrie { get; set; }
        public virtual ICollection<Tour> Tour { get; set; }
    }
}
