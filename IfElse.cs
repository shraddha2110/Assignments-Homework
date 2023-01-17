using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class IfElse_calculation
    {
        //Task 1 - Accept the 3 subject marks & calculate the total & percentage. & print grade as below
        //> 75  – > A
        //50 - 75 → B
        //40 - 50 → C
        //< 40 Fail

        static void Main(string[] args)
        {
            Console.WriteLine("enter the marks");
            Console.WriteLine("physics");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("chemistry");
            int chemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("math");
            int math = int.Parse(Console.ReadLine());

            double per, Total;

            Total = physics + chemistry + math;
            Console.WriteLine("TOTAL MARKS IS=" + Total);

            per = Total / 3.0;
            Console.WriteLine("PERCENTAGE IS=" + per);

            if (per > 75)
            {
                Console.WriteLine("GRADE A");
            }
            else if (per < 75 && per >= 50)
            {
                Console.WriteLine("GRADE B");
            }
            else if (per < 50 && per >= 40)
            {
                Console.WriteLine("GRADE C");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

        }

        internal class IfElse_LeapYr
        {

            //task 2 - accept a year from user & print whether it is leap year or not

            static void Main(string[] args)
            {
                Console.WriteLine("enter year : ");
                int year = int.Parse(Console.ReadLine());

                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                    Console.WriteLine(" is a leap year.", year);

                else
                    Console.WriteLine(" is not a leap year.", year);

                Console.ReadLine();
            }
        }


             //Task 3 - Accept 3 numbers from user & print greatest number from 3
        internal class IfElse_GreatestNo
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter the 1st no");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the2nd no");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the 3rd no");
                int num3 = int.Parse(Console.ReadLine());
                int max = 0;

                if (num1 > num2 && num1 > num3)
                {
                    max = num1;

                }
                else if (num2 > num1 && num2 > num3)
                {
                    max = num2;
                }
                else
                {
                    max = num3;
                }
                Console.WriteLine("The greater no is=" + max);
            }
        }


        //Task 4 - Accept actual value & sell value of a product & print profit or loss
        internal class IfElse_ProfitLoss
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter the actual value");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the sell value");
                int num2 = int.Parse(Console.ReadLine());
                int num3;

                if (num2 > num1)
                {
                    num3 = num2 - num1;
                    Console.WriteLine("Profit is=" + num3);
                }
                else if (num1 > num2)
                {
                    num3 = num1 - num2;
                    Console.WriteLine("Loss is=" + num3);
                }
                else
                {
                    Console.WriteLine("NO PROFIT AND LOSS");
                }
            }
        }


        //Task 5 - Write a program to accept a number & print day (e.g. 0- Sunday 1- Monday, 2-Tue…)
        internal class IfElse_Weekdays
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter the weekdays: sunday = 1, monday = 2, tuesday = 3, wednesday = 4, thursday = 5, friday = 6, saturday = 7");
                int num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    Console.WriteLine("Today is sunday");
                }
                else if (num == 2)
                {
                    Console.WriteLine("Today is monday");
                }
                else if (num == 3)
                {
                    Console.WriteLine("Today is tuesday");
                }
                else if (num == 4)
                {
                    Console.WriteLine("Today is wednesday");
                }
                else if (num == 5)
                {
                    Console.WriteLine("Today is thursday");
                }
                else if (num == 6)
                {
                    Console.WriteLine("Today is friday");
                }
                else if (num == 7)
                {
                    Console.WriteLine("Today is saturday");
                }
                else
                {
                    Console.WriteLine("Enter correct no.");
                }
            }
        }
        internal class IfElse_Vote
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("This user can vote");
                }
                else
                {
                    Console.WriteLine("This user can not vote");
                }

            }
        }
        internal class IfElse_Vowels
        {
            static void Main(string[] args)
            {
                char ch = 'z';

                if (ch == 'a')
                {
                    Console.WriteLine("Vowel");
                }
                else if (ch == 'e')
                {
                    Console.WriteLine("Vowel");
                }
                else if (ch == 'i')
                {
                    Console.WriteLine("Vowel");
                }
                else if (ch == 'o')
                {
                    Console.WriteLine("Vowel");
                }
                else if (ch == 'u')
                {
                    Console.WriteLine("Vowel");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }

            }
        }
    }
}
