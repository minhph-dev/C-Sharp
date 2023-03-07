using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerProduct
{
    public class Product
    {
        public int ProductID;
        public string productName;
        public int quantity;
        public float UnitPrice;

        public int pId
        {
            get { return ProductID; }
            set { ProductID = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public float pQuantity
        {
            get { return UnitPrice; }
            set { UnitPrice = value; }
        }

        public Product()
        {

        }
        public Product(int productID, string productName, int quantity, float unitPrice)
        {
            ProductID = productID;
            this.productName = productName;
            this.quantity = quantity;
            UnitPrice = unitPrice;
        }

        public double subtotal()
        {
            return this.quantity * this.UnitPrice;
        }

        public void input()
        {
            Console.Write("Enter Id: ");
            this.ProductID = int.Parse(Console.ReadLine());
            Console.Write("Enter productName: ");
            this.productName+= Console.ReadLine(); 
            Console.Write("Enter quantity: ");
            this.quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter UnitPrice: ");
            this.UnitPrice= float.Parse(Console.ReadLine());    
        }

        public void displayDetail()
        {
            Console.WriteLine(
              "| Id: " + this.ProductID +
              "| Product Name: " + this.productName +
              "| Quantity: " + this.quantity +
              "| Unit Price: " + this.UnitPrice + 
              "| Sub total: " + this.subtotal() 
              );
        }
    }
}
