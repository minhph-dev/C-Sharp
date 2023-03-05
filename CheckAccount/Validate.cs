using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckAccount
{
    public delegate void MyValid(string s);
    internal class Validate
    {
        public event MyValid Print;
        public void CheckValid(string s)
        {
            throw new Exception(s);
        }

        public void Check(string s)
        {
            CheckValid(s);
        }

    }
}
