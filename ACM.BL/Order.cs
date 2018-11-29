using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {

        public Order()
        {

        }


        public Order(int orderId)
        {
            this.OrderId = orderId;
        }





        //Composition relations with  IdS: Between  Order->customer and  Order->Address
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        /// <summary>
        ///  Ende relationship
        /// </summary>




        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        //Compositional relationship between Order --> OrderItems
        public List<OrderItem> orderItems { get; set; }

        /// <summary>
        ///  Ende relationship
        /// </summary>

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }



        public bool Validate()
        {

            var isValid = true;

            if (OrderDate == null) isValid = false;
            return isValid;

        }

    }
}
