using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Proizvod = new HashSet<Proizvod>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<Proizvod> Proizvod { get; set; }
    }
}
