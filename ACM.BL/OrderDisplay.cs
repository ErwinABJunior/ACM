using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderDisplay
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        public int ShippingAddressId { get; set; }

        public Address ShippingAddres { get; set; }
        public List<OrderDisplayItem> OrderDisplayItemsList { get; set; }


    }
}
