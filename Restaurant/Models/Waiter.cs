using System;
using System.Collections.Generic;

namespace Restaurant
{
    public partial class Waiter
    {
        public int WaiterId { get; set; }
        public int? TableNumber { get; set; }
        public int Salary { get; set; }
        public string AddressRes { get; set; }

        public virtual Restaurant AddressResNavigation { get; set; }
        public virtual TableRes TableNumberNavigation { get; set; }
    }
}
