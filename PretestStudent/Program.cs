using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretestStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            int choice;
            do
            {
                Console.WriteLine("\n 1.Add\n 2.Display All\n 3.Display pass student\n 4.Search by Name\n 5.Remove By Id\n 6.Exit");
                Console.Write("Please choose an option: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        studentManager.AddStudent();
                        break;
                    case 2:
                        studentManager.showData();
                        break;
                    case 3:
                        studentManager.displayPassStudent();
                        break;
                    case 4:
                        Console.Write("Enter Name want Search: ");
                        string name = Console.ReadLine();
                        studentManager.searchStudentByName(name);
                        break;
                    case 5:
                        Console.Write("Enter Id want delete: ");
                        string id = Console.ReadLine();
                        studentManager.deleteStudent(id);
                        break;
                    case 6:
                        Console.WriteLine("Bye");
                        break;
                    default:
                        Console.WriteLine("Wrong choice.Try again");
                        break;
                }
            }while(choice!=6);
        }
    }
}
