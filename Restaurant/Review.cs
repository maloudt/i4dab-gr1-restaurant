using System;
using System.Collections.Generic;

namespace Restaurant
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public string ReviewerName { get; set; }
        public int Stars { get; set; }
        public string ReviewText { get; set; }
        public DateTime Time { get; set; }
        public string AddressRes { get; set; }

        public virtual Restaurant AddressResNavigation { get; set; }
    }
}
