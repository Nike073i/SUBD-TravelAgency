using System;
using System.Collections.Generic;

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Client
    {
        public Client()
        {
            Sale = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Middlename { get; set; }
        public string Contactnumber { get; set; }

        public virtual ICollection<Sale> Sale { get; set; }
    }
}
