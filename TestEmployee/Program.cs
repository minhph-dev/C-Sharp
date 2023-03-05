using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmployee
{
    /*
A - Create a class Employees with (9 marks):
1. Fields (1 mark):
empID int Employee ID
empName String Employee Name
department String Department
numWork int Number of years working
2. Properties (2 mark): 
Create properties: empID, empName, department, numWork
3. Constructors (2 marks):
- Create a no arguments constructor: initialize empID = 10, empName with your name, department=“Aptech”, numWork=0- Create a constructor which has arguments: initialize empID, empName, department, numWork with the passed arguments.
4. Methods (4 marks):
- Create a method named: Input() to input data for employee.- Create a method named: DisplayDetail() which displays the detail of Employee: empName, department, numWork.
B- Create a class TemporaryEmp inherite Employees (6 marks).

1. Fields (1 mark):
workDay : int (So ngay cong)
2. Constructor (1 mark):
Create a constructor which inherite constructor of base class (Employees) and initialize workDay with passed value.
3. Methods (4 marks):
Implement abstract method CalculateSalary() which initialize workDay with a number from keyboard.
If workDay <=25 : Salary = workDay * 50.000
If workDay>25 : Salary=25* 50.000+ (workDay-25) *50.000 * 2
Return the salary.
Create a override method named DisplayDetail() which displays detail of TemporayEmp: empName, DOB, department, salary.
C. Create a class EmployeeManagement (5 marks).

1. Fields (1 mark):
an array store up to 100 employees.
int n: number of employees now.
2. Methods (4 marrks)
display_array_Emp: Display array of Employee.
display_max_numWork: Display employee has max number of years working.
D. Create a class Test (5 marks).
methods: menu()
press 1 to enter a Employee
press 2 to display array of Employee
press 3 to display array of Employee has max number of years working.
press 4 to exit 

     */
    internal class Program
    {
        static public void Menu()
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();
            int choice;
            do
            {
                Console.WriteLine("\n 1.Add Employee\n 2.Display All\n 3.Display List Employee has max number of years working\n 4.Exit");
                Console.Write("Please choose an option: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employeeManagement.Add();
                        break;
                    case 2:
                        employeeManagement.displayAll();
                        break;
                    case 3:
                        employeeManagement.displayMaxWordDay();
                        break;
                    case 4:
                        Console.WriteLine("Bye");
                        break;
                    default:
                        Console.WriteLine("Wrong choice.Try again");
                        break;
                }
            } while (choice != 4);
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
