using System;
using System.Collections.Generic;

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Sale
    {
        public int Id { get; set; }
        public int Tourid { get; set; }
        public int Clientid { get; set; }
        public DateTime Dateofsale { get; set; }

        public virtual Client Client { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
