using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBook
{
    public delegate void DBook(string s);
    public class MyEvent
    {
        public event DBook Echeck;
        public void handler(string s)
        {
            Echeck(s);
        }
    }
}
