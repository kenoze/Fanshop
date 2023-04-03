using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Narudzba
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public byte OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int StoreId { get; set; }
        public int StaffId { get; set; }

        public virtual Kupac Customer { get; set; }
        public virtual Osoblje Staff { get; set; }
        public virtual Trgovina Store { get; set; }
    }
}
