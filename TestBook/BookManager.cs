using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBook
{
    public class BookManager
    {
        List<Book> bList;
        public Book pBookList
        {
            set
            {
                bList.Add(value); 
            }
        }

        public BookManager()
        {
            bList = new List<Book>();
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
