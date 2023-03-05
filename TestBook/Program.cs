using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestBook
{
    /****
 * R1. Tạo class MyEvent gồm : 
 *    + tạo delegate void DBook(string s);
 *    + tạo event tên ECheck dựa trẹn delegate DBook
 *    + khai báo hàm tên handler(string s) không trả trị để gọi Event
 * R2. Tạo class Book
 *  string id, name;
 *  int price, year;
 *  + tạo các properties cho các filed trên
 *    validate : Id bắt đầu ISBNxxxx x là ký số bất kỳ
 *               name : ít nhất 3 ký tự
 *               price >0
 *               year : phải > 1990 và < 2023
 * + viết hàm checkValue(string s) : để bắt lỗi.
 * + viết hàm input() : để nhập book.
 * R3. Tạo class BookManager :
 *    + khai báo List<Book> để chứa các books
 *    
 * R4. Tạo lớp chưa hàm mian() :
 *    Menu :
 *       1.Add Book
 *       2.Show All
 *       3.Print out book with year 2000
 *       4.Quit
 * 
 * 
 * 
 */
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();
            Book book;
            int choice;
            do
            {
                Console.WriteLine("\n 1.Add\n 2.Show All\n 3.Print out book with year 2000\n 4.Exit");
                Console.Write("Please choose an option: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        book = new Book();
                        book.input();
                        bookManager.pBookList = book;
                        break;
                    case 2:
                        Console.WriteLine("=== All ===");
                        int count1 = 0;
                        foreach (var item in bookManager.GetEnumrator())
                        {
                            Console.WriteLine(item.ToString());
                            count1++;
                        }
                        if (count1 == 0)
                        {
                            Console.WriteLine("List Empty !!!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("=== List Book Year 2000 ===");
                        int count2 = 0;
                        foreach (var item in bookManager.GetEnumrator())
                        {
                            if (item.pYear.Equals(2000))
                            {
                                Console.WriteLine(item.ToString());
                                count2++;
                            }
                        }
                        if(count2 == 0)
                        {
                            Console.WriteLine("Not Found !!!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Bye");
                        break;
                    default:
                        Console.WriteLine("Wrong choice.Try again");
                        break;
                }
            } while (choice != 4);
        }
    }
}
