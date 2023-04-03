using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Kupac
    {
        public Kupac()
        {
            Narudzba = new HashSet<Narudzba>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Narudzba> Narudzba { get; set; }
    }
}
