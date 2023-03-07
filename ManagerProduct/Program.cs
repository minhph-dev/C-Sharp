using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerProduct prod = new ManagerProduct();
            string choice;

            while (true)
            {
                Console.Write("==========================");
                Console.WriteLine("\n AddNew\n Remove \n Find \n ListAll\n Quit");
                Console.Write("Please choose an option: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "AddNew":
                        prod.AddNew();
                        break;
                    case "Remove":
                        prod.RemoveProd();
                        break;
                    case "Find":
                        prod.find();
                        break;
                    case "ListAll":
                        prod.listAll();
                        break;
                    case "Quit":
                        Console.WriteLine("Bye");
                        return;
                    default:
                        Console.WriteLine("Wrong choice.Try again");
                        break;
                }

            }
        }
    }
}
