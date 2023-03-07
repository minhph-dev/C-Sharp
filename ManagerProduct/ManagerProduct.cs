using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerProduct
{
    internal class ManagerProduct
    {

        List<Product> prodList;
        Product prod;

        public ManagerProduct()
        {
            prodList = new List<Product>();
        }

        public void listAll()
        {
            if (prodList.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                foreach (var prod in prodList)
                {
                    prod.displayDetail();
                }
            }
        }

        public void AddNew()
        {
            Product prod = new Product();
            prod.input();
            prodList.Add(prod);
        }

        public void RemoveProd()
        {
            int id;
            Console.Write("Enter Code Want Delete: ");
            id = int.Parse(Console.ReadLine());
            int count = 0;
            if (prodList.Count == 0)
            {
                Console.WriteLine("List is empty!!!");
                return;
            }

            foreach (var item in prodList)
            {
                if (item.pId.Equals(id))
                {
                    prodList.Remove(item);
                    count++;
                    Console.WriteLine("Delete Success");
                    return;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Not found!!!");
            }
        }

        public void find()
        {
            int id;
            Console.Write("Enter Code Want Search: ");
            id = int.Parse(Console.ReadLine());
            int count = 0;
            if (prodList.Count == 0)
            {
                Console.WriteLine("List is empty!!!");
                return;
            }
          
            foreach (var item in prodList)
            {
                if (item.pId.Equals(id))
                {
                    item.displayDetail();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Not found!!!");
            }
        }
    }
}
