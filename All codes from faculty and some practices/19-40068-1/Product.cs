using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance
{
    public class Product
    {
        public int productId, price;
        public string ProductName;

        public int ProductId
        {
            set { this.productId = value; }
            get { return this.productId; }
        }
        public string ProductName
        {
            set { this.productName = value; }
            get { return this.productName; }
        }
        public int Price
        {
            set { this.price = value; }
            get { return this.price; }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Product ID : \nPrice :\nName :" this.ProductId, this.Price, this.ProductName);
        }
    }
    
}
