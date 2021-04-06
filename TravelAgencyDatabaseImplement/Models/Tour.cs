using System;
using System.Collections.Generic;

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Tour
    {
        public Tour()
        {
            Sale = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public DateTime Dateofbegininng { get; set; }
        public int Numberofdays { get; set; }
        public int Numberofpeople { get; set; }
        public int Hotelid { get; set; }
        public DateTime Publicationdate { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
