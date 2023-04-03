using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Trgovina
    {
        public Trgovina()
        {
            Narudzba = new HashSet<Narudzba>();
            Osoblje = new HashSet<Osoblje>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Narudzba> Narudzba { get; set; }
        public virtual ICollection<Osoblje> Osoblje { get; set; }
    }
}
