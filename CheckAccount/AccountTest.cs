using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckAccount
{
    internal class AccountTest
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            string choice;

            while (true)
            {
                Console.Write("==========================");
                Console.WriteLine("\n Deposit\n Withdraw \n Show\n Quit");
                Console.Write("Please choose an option: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "Deposit":
                        while (true)
                        {
                            try
                            {
                                Console.Write("Enter Deposit:");
                                account.Deposit = double.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case "Withdraw":
                        while (true)
                        {
                            try
                            {
                                Console.Write("Enter Withdraw:");
                                account.WithDraw = double.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case "Show":
                        account.Display();
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
