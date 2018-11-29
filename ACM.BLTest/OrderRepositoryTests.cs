using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    [TestClass()]
    public class OrderRepositoryTests
    {

        [TestMethod()]
        public void RetrieveOrderDisplayTest()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                ShippingAddres = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                OrderDisplayItemsList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        OrderQuantity = 2,
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M
                    },
                    new OrderDisplayItem()
                    {
                        OrderQuantity = 1,
                        ProductName = "Rake",
                        PurchasePrice = 6M
                    }
                }
            };

            //-- Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            //-- Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddres.AddressType, actual.ShippingAddres.AddressType);
            Assert.AreEqual(expected.ShippingAddres.StreetLine1, actual.ShippingAddres.StreetLine1);
            Assert.AreEqual(expected.ShippingAddres.City, actual.ShippingAddres.City);
            Assert.AreEqual(expected.ShippingAddres.State, actual.ShippingAddres.State);
            Assert.AreEqual(expected.ShippingAddres.Country, actual.ShippingAddres.Country);
            Assert.AreEqual(expected.ShippingAddres.PostalCode, actual.ShippingAddres.PostalCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.OrderDisplayItemsList[i].OrderQuantity, actual.OrderDisplayItemsList[i].OrderQuantity);
                Assert.AreEqual(expected.OrderDisplayItemsList[i].ProductName, actual.OrderDisplayItemsList[i].ProductName);
                Assert.AreEqual(expected.OrderDisplayItemsList[i].PurchasePrice, actual.OrderDisplayItemsList[i].PurchasePrice);
            }
        }


    }
}
