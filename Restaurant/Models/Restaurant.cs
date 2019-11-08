using System;
using System.Collections.Generic;

namespace Restaurant
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Dish = new HashSet<Dish>();
            Guest = new HashSet<Guest>();
            Review = new HashSet<Review>();
            TableRes = new HashSet<TableRes>();
            Waiter = new HashSet<Waiter>();
        }

        public string AddressRes { get; set; }
        public string NameRes { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Dish> Dish { get; set; }
        public virtual ICollection<Guest> Guest { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<TableRes> TableRes { get; set; }
        public virtual ICollection<Waiter> Waiter { get; set; }
    }
}
