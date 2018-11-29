using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderRepository
    {


        public Order Retrievew(int orderId)
        {
            Order order = new Order(orderId);


            if (orderId == 10)
            {

                order.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;

        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            // Code that retrieves the defined order fields
            var addressRepository = new AddressRepository();

            // Temporary Hard-coded data
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                orderDisplay.ShippingAddres = addressRepository.Retrieve(1);
            }

            orderDisplay.OrderDisplayItemsList = new List<OrderDisplayItem>();

            // Code that retrieves the order items

            // Temporary Hard-coded data
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayItemsList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.OrderDisplayItemsList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }


        public bool Save(Order order)
        {
            return true;
        }

    }
}
