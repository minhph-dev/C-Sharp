using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretestStudent
{
    public class StudentManager
    {
        List<Student> sList;
        Student student;
        public StudentManager()
        {
            sList = new List<Student>();
        }
        //ham Add Student
        public void AddStudent()
        {
            student = new Student();
            //nhap Id
            while (true)
            {
                try
                {
                    Console.Write("Enter Id: ");
                    student.pId = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //nhap name
            while (true)
            {
                try
                {
                    Console.Write("Enter FullName: ");
                    student.fullName = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //nhap dob
            while (true)
            {
                try
                {
                    Console.Write("Enter Date Of Birth: ");
                    student.pDob = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //nhap diem IT
            while (true)
            {
                try
                {
                    Console.Write("Enter IT mark: ");
                    student.pIT = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //nhap diem English
            while (true)
            {
                try
                {
                    Console.Write("Enter English mark: ");
                    student.pEnglish = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            sList.Add(student);
        }//het ham add student

        public void showData()
        {
            if(sList.Count == 0)
            {
                Console.WriteLine("Student List is empty");
                return;
            }
            foreach (var item in sList)
            {
                item.display();
            }
        }//het ham show

        //hien thi sinh vien dau
        public void displayPassStudent()
        {
            if (sList.Count == 0)
            {
                Console.WriteLine("Student List is empty");
                return;
            }
            int count = 0;
            foreach (var item in sList)
            {
                if(item.Avg() >= 40)
                {
                    item.display();
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No pass Student");
                return;
            }
        }//het

        //search student
        public void searchStudentByName(string name)
        {
            if (sList.Count == 0)
            {
                Console.WriteLine("Student List is empty");
                return;
            }

            int count = 0;
            foreach (var item in sList)
            {
                if (item.fullName.Equals(name)){
                    item.display();
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Not Found !!!");
            }
            
        }

        //delete student
        public void deleteStudent(string id)
        {
            int count = 0;
            for (int i = 0; i < sList.Count; i++)
            {
                if (sList[i].pId.Equals(id))
                {
                    sList.Remove(sList[i]);
                    count++;
                    Console.WriteLine("Deleted ");
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Id entered is not exist i List");
            }
        }
    }
}
