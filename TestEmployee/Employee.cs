using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmployee
{
    public abstract class Employee
    {
        public int empID;
        public string empName , department;
        public int numWork = 0;

        public Employee()
        {
            empID= 10;
            empName = "Minh";
            department = "Aptech";
            numWork = 0;
        }
        public Employee(int empID, string empName, string department, int numWork, int pEmpID, string pEmpName, string pDepartment, int pNumWork)
        {
            this.empID = empID;
            this.empName = empName;
            this.department = department;
            this.numWork = numWork;
            this.pEmpID = pEmpID;
            this.pEmpName = pEmpName;
            this.pDepartment = pDepartment;
            this.pNumWork = pNumWork;
        }

        public int pEmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public string pEmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public string pDepartment
        {
            get { return department; }
            set { department = value; }
        }

        public int pNumWork
        {
            get { return numWork; }
            set { numWork = value; }
        }

        public virtual void input()
        {
            Console.Write("Enter Employee Id: ");
            this.empID = int.Parse(Console.ReadLine().Trim());
            Console.Write("Enter Employee Name: ");
            this.empName = Console.ReadLine().Trim();
            Console.Write("Enter Department: ");
            this.department = Console.ReadLine().Trim();
            Console.Write("Enter Number of years working: ");
            this.numWork = int.Parse(Console.ReadLine().Trim());
        }

        public virtual void DisplayDetail()
        {
            Console.Write(
               "| EmpId: " + this.empID +
               "| EmpName: " + this.empName +
               "| Department: " + this.department +
               "| Number of years working: " + this.numWork
               );
        }

        public abstract double CalculateSalary();
    }
}
