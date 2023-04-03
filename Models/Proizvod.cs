using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Proizvod
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public short ModelYear { get; set; }
        public decimal ListPrice { get; set; }
        public string SlikaUrl { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Kategorije Category { get; set; }
    }
}
