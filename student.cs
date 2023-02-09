using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        static void Main(string[] args)
        {
            //create object of student class
            //create emp class accept empid, empname & salary--->display
            //create Book class accept author name, book name, price & display

            Student stud = new Student();
            stud.Accept(101, "Rohan", 78.77);
            string result = stud.Display();
            Console.WriteLine(result) ;
        }
    }
}

