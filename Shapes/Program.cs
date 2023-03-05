using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeCollections shapeCollections = new ShapeCollections();
            string choice;

            while (true)
            {
                Console.Write("==================================");
                Console.WriteLine("\n Circle\n Reactangle \n Show\n Quit");
                Console.Write("Please choose an option: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "Circle":
                        shapeCollections.AddCircle();
                        break;
                    case "Reactangle":
                        shapeCollections.AddReactangle();
                        break;
                    case "Show":
                        Console.WriteLine("=== Show All ===");
                        int count = 0;
                        foreach (var item in shapeCollections.GetEnumrator())
                        {
                            item.ShowArea();
                            count++;
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("List is  empty !!!");
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
