using System;
using System.Collections.Generic;

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Country
    {
        public Country()
        {
            Hotel = new HashSet<Hotel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }

        public virtual ICollection<Hotel> Hotel { get; set; }
    }
}
