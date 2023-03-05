using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretestBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCollections bookCollections = new BookCollections();
            string choice;
           
            while (true)
            {
                Console.Write("==========================");
                Console.WriteLine("\n Add\n SaleList \n ListAll\n Quit");
                Console.Write("Please choose an option: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "Add":
                        bookCollections.addBook();
                        break;
                    case "SaleList":
                        Console.WriteLine("=== Sale List ===");
                        bookCollections.SaleList();
                        break;
                    case "ListAll":
                        Console.WriteLine("=== Show All ===");
                        int count = 0;
                        foreach (var item in bookCollections.GetEnumrator())
                        {
                            item.PrintInfor();
                            count++;
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("Book List is  empty !!!");
                        }
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
