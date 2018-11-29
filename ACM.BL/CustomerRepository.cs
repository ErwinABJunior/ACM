using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {





        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }


        /// <summary>
        /// Retrie´ve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {

            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            //Temporary hard coded values  to return a populadxted  customer
            if (customerId == 1)
            {

                customer.EmailAdress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.Lastname = "Baggins";


            }

            return customer;
        }


        /// <summary>
        /// Returns all Customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }



        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            return true;
        }




    }
}
