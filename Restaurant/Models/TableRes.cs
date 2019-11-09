using System;
using System.Collections.Generic;

namespace Restaurant
{
    public partial class TableRes
    {
        public TableRes()
        {
            Guest = new HashSet<Guest>();
            Waiter = new HashSet<Waiter>();
        }

        public int TableId { get; set; }
        public int TableNumber { get; set; }
        public int Chairs { get; set; }
        public string AddressRes { get; set; }

        public virtual Restaurant AddressResNavigation { get; set; }
        public virtual ICollection<Guest> Guest { get; set; }
        public virtual ICollection<Waiter> Waiter { get; set; }
    }
}
