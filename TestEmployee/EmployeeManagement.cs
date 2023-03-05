using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TestEmployee
{
    public class EmployeeManagement
    {
        static int max = 100, n;
        TemporaryEmp[] empList = new TemporaryEmp[max];
        public EmployeeManagement()
        {
        }

        public void Add()
        {
            if (n == max)
            {
                Console.WriteLine("Out memory !!!");
                return;
            }
            TemporaryEmp emp = new TemporaryEmp();
            emp.input();
            empList[n] = emp;
            n++;
        }
        public void displayAll()
        {
            if (n == 0)
            {
                Console.WriteLine("Employee List is empty");
                return;
            }
            Console.WriteLine("=== All ===");
            for (int i = 0; i < n; i++)
            {
                empList[i].DisplayDetail();
            }
        }

        public void displayMaxWordDay()
        {
            TemporaryEmp max = empList[0];
            if (n == 0)
            {
                Console.WriteLine("Employee List is empty");
                return;
            }
            for (int i = 1; i < n; i++)
            {
                if (empList[i].numWork > max.numWork)
                    max = empList[i];
            }
            Console.WriteLine("=== Max WorkDay ===");
            max.DisplayDetail();
        }
    }
}
