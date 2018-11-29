using System.Collections.Generic;

namespace ACM.BL
{
    public class Product
    {

        public Product()
        {

        }


        public Product(int productId)
        {
            this.ProductId = productId;
        }


        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }


        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }



        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }


        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

        public override string ToString()
        {
            return ProductName;
        }


        //public string Log()
        //{
        //    var logString = this.ProductId + ": " +
        //                  this.ProductName + " " +
        //                  "Detail: " + this.ProductDescription + " " +
        //                  "Status: " + this.EntityState.ToString();
        //    return logString;
        //}


    }
}
