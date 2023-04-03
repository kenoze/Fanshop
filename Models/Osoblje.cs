using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Osoblje
    {
        public Osoblje()
        {
            InverseManager = new HashSet<Osoblje>();
            Narudzba = new HashSet<Narudzba>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte Active { get; set; }
        public int StoreId { get; set; }
        public int? ManagerId { get; set; }

        public virtual Osoblje Manager { get; set; }
        public virtual Trgovina Store { get; set; }
        public virtual ICollection<Osoblje> InverseManager { get; set; }
        public virtual ICollection<Narudzba> Narudzba { get; set; }
    }
}
