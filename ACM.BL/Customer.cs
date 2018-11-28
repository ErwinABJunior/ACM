namespace ACM.BL
{
    public class Customer
    {


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
