using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PretestStudent
{
    //khai bao delegate
    public delegate void ValidDelegate(string s);
    public class Student
    {
        public string id, fullName;
        DateTime dob;
        int IT, English;
        //khai bao event dua tren delegate
        public event ValidDelegate Valid;
        public void ValidProcess(string s)
        {
            throw new Exception(s);
        }
        public Student()
        {
            Valid += ValidProcess;
        }
        //khai bao cac properties
        public string pId
        {
            get { return id; }
            set
            {
                Regex regex = new Regex("^ST-\\d{3,5}$");
                if(regex.IsMatch(value))
                {
                    id = value;
                }
                else
                {
                    Valid("Student Id must be format ST-xxx[xx] with x any digit");
                }

            }
        }//het pId

        public DateTime pDob
        {
            get { return dob; }
            set
            {
                if(DateTime.Now.Year - value.Year >=18)
                {
                    dob = value;
                }
                else
                {
                    Valid("Formal is [yyyy/mm/dd] At least 18 years old");
                }
            }
        }//het pDob

        public int pIT
        {
            get { return IT; }
            set
            {
                if (value>=0 && value<=100)
                {
                    IT = value;
                }
                else
                {
                    Valid("IT mark between 0 and 100");
                }
            }
        }//het pIT

        public int pEnglish
        {
            get { return English; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    English = value;
                }
                else
                {
                    Valid("English mark between 0 and 100");
                }
            }
        }//het pEnglish

        public int Avg()
        {
            return (IT + English) / 2;
        }

        public void display()
        {
            Console.WriteLine(
                "\tId: "+ id + 
                "\tName: " + fullName + 
                "\tDob: " + dob + 
                "\tIT: " + IT + 
                "\tEnglish: " + English + 
                "\tAvg: " + Avg());
        }
    }
}
