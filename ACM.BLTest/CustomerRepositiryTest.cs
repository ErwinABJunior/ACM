using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositiryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //--Arange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {

                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                Lastname = "Baggins"
            };

            //--Act  
            var actual = customerRepository.Retrieve(1);

            //--Assert 
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.Lastname, actual.Lastname);

        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {

            //--Arange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {

                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",

                Lastname = "Baggins",
                AddressList = new List<Address>()
                    {
                        new Address()
                        {
                            AddressType = 1,
                            StreetLine1 = "Bag End",
                            StreetLine2 = "Bagshot row",
                            City = "Hobbiton",
                            State = "Shire",
                            Country = "Middle Earth",
                            PostalCode = "144"
                        },
                        new Address()
                        {
                            AddressType = 2,
                            StreetLine1 = "Green Dragon",
                            City = "Bywater",
                            State = "Shire",
                            Country = "Middle Earth",
                            PostalCode = "146"
                        }
                    }
            };



            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.Lastname, actual.Lastname);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }

        }


    }


}
