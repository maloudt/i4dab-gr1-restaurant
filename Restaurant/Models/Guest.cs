using System;
using System.Collections.Generic;

namespace Restaurant
{
    public partial class Guest
    {
        public int GuestId { get; set; }
        public string NameBooker { get; set; }
        public int? TableNumber { get; set; }
        public int? PartySize { get; set; }
        public DateTime Time { get; set; }
        public string AddressRes { get; set; }

        public virtual Restaurant AddressResNavigation { get; set; }
        public virtual TableRes TableNumberNavigation { get; set; }
    }
}
