using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Kategorije
    {
        public Kategorije()
        {
            Proizvod = new HashSet<Proizvod>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Proizvod> Proizvod { get; set; }
    }
}
