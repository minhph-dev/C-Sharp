using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretestBook
{
    public class BookCollections
    {
        List<Book> bList ;

        public BookCollections()
        {
            bList = new List<Book>();
        }
        public void addBook()
        {
            Book book = new Book();
            while (true)
            {
                try
                {
                    Console.Write("Enter Title: ");
                    book.pTitle = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter Price: ");
                    book.pPrice = double.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter isSale: ");
                    book.pIsSale = bool.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            bList.Add(book);
        }

        public void SaleList()
        {
            if (bList.Count == 0)
            {
                Console.WriteLine("Book List is empty !!!");
                return;
            }
            int count = 0;
            foreach (var item in bList)
            {
                if (item.isSale == true)
                {
                    item.PrintInfor();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No Book IsSale");
                return;
            }
        }

        public IEnumerable<Book> GetEnumrator()
        {
            foreach (var item in bList)
            {
                yield return item;
            }
        }

    }
}
