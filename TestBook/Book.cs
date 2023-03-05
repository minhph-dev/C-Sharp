using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestBook
{
    public class Book 
    {
        string id, name;
        int price, year;
        MyEvent e = new MyEvent();
        public string pId
        {
            get { return id; }
            set
            {
                Regex regex = new Regex("^ISBN\\d{4}$");
                if (regex.IsMatch(value))
                {
                    id = value;
                }
                else
                {
                    e.handler("Id must be format ISBNxxxx with x any digit");
                }

            }
        }

        public string pName
        {
            get { return name; }
            set
            {
                if (value.Length >=3)
                {
                    name = value;
                }
                else
                {
                    e.handler("Name must minimum 3 char");
                }

            }
        }

        public int pPrice
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
                    e.handler("Name must minimum 3 char");
                }

            }
        }

        public int pYear
        {
            get { return year; }
            set
            {
                if (value > 1990 && value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else
                {
                    e.handler("Year must be > 1990 and < 2023");
                }
            }
        }

        public void checkValue(string s)
        {
            throw new Exception(s);
        }
        public Book()
        {
             e = new MyEvent();
             e.Echeck += checkValue;
        }
        public void input()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Id: ");
                    pId = Console.ReadLine().Trim();
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
                    Console.Write("Enter Name: ");
                    pName = Console.ReadLine().Trim();
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
                    pPrice = int.Parse(Console.ReadLine().Trim());
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
                    Console.Write("Enter Year: ");
                    pYear = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        public override string ToString()
        {
            return string.Format("\tId: {0} \tName: {1} \tPrice: {2}, \tYear: {3}", id, name, price, year);
        }
    }
}
