using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {



        public Customer()
            : this(0) //Constructr Chaining calling another  constructor.
        {

        }

        public Customer(int customerId)
        {
            this.CustomerID = customerId;
            AddressList = new List<Address>();
        }

        /// <summary>
        /// Composition Relationshio   Between Address - Customer
        /// </summary>
        public Address WorkAddress { get; set; }
        public Address HomeAddress { get; set; }
        //Alternativ  
        public List<Address> AddressList { get; set; }

        /// <summary>
        ///  Composition END
        /// </summary>
        //----------------------------------------------------------


        public int CustomerType { get; set; }
        public static int InstanceCount { get; set; }

        private string _lastname;

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }


        public int CustomerID { get; private set; }
        public string FirstName { get; set; }
        public string EmailAdress { get; set; }



        public bool Validate()
        {

            var isValid = true;
            if (string.IsNullOrWhiteSpace(Lastname)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;

            return isValid;



        }


        /// <summary>
        /// Returns a Customer  full name
        /// </summary>
        public string FullName
        {
            get
            {
                string fullName = Lastname;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

    }
}
