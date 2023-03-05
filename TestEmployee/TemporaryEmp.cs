using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmployee
{
    public class TemporaryEmp:Employee
    {
        int wordDay = 0;

        public override void DisplayDetail()
        {
            base.DisplayDetail();
            Console.WriteLine("| WorkDay: " + this.wordDay + 
                          "| Salary: " + this.CalculateSalary());
        }

        public TemporaryEmp()
        {

        }

        public TemporaryEmp(int wordDay)
        {
            this.wordDay = wordDay;
        }

        public override void input()
        {
            base.input();
            Console.Write("Enter WorkDay: ");
            this.wordDay = int.Parse(Console.ReadLine().Trim());
            this.CalculateSalary();
        }

        public override double CalculateSalary()
        {
            double salary;
            if (this.wordDay <= 25)
            {
                salary = this.wordDay * 50000;
            }
            else
            {
                salary = (25 * 50000) + (this.wordDay - 25) * (50000 * 2);
            }
            return salary;
        }
    }
}
