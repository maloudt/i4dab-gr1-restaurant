using System;
using System.Collections.Generic;

namespace Restaurant
{
    public partial class Dish
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public string DishDescription { get; set; }
        public int? Price { get; set; }
        public string Category { get; set; }
        public string AddressRes { get; set; }

        public virtual Restaurant AddressResNavigation { get; set; }
    }
}
