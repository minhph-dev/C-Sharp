using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PretestBook
{
    public delegate void ValidDelegate(string s);
    public class Book : Document
    {
        public string title;
        public double price;
        public bool isSale;
        public override void PrintInfor()
        {
            Console.WriteLine(
                "\tTitle: " + title +
                "\tPrice: " + price +
                "\tIsSale: " + isSale);
        }

        public event ValidDelegate Valid;
        public void ValidProcess(string s)
        {
            throw new Exception(s);
        }
        public Book()
        {
            Valid += ValidProcess;
        }

        public string pTitle
        {
            get { return title; }
            set
            {
                Regex regex = new Regex("[^\\s][A-z0-9A-z\\s]+");
                if (regex.IsMatch(value))
                {
                    title = value;
                }
                else
                {
                    Valid("Title must be letters, digits, white space");
                }

            }
        }

        public double pPrice
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Valid("Price must be > 0");
                }

            }
        }

        public bool pIsSale
        {
            get { return isSale; }
            set
            {
                if (value== true || value == false)
                {
                    isSale = value;
                }
                else
                {
                    Valid("IsSale must be value true or false");
                }
               

            }
        }
    }
}
