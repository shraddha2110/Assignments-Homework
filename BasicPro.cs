using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BasicPro
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" This is first program ");
            char gender = 'M';
            string name = " Rohan ";
            double percentage = 89.55;
            Console.WriteLine(" Gender is " + gender);
            Console.WriteLine(" My name is " + name);
            Console.WriteLine(" My percentage " + percentage);

            //OR
            //using +concatination 
            Console.WriteLine(" Gender is " + gender + " my name is " + name + " my perncentage " + percentage);

            //OR - using place holder
            //Console.WriteLine(" Gender is { 0 } my name is { 1 } & percentage { 2 } ", gender, name, percentage);
            Console.WriteLine(" My percentage { 0 } ", percentage);


            //OR - using string interpolation $ sign

            Console.WriteLine($" Gender is {gender} my name is {name} & percentage {percentage} ");
            Console.WriteLine($" my name is {name} ");
        }
    }
    internal class BasicPro1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a name ");
            string name = Console.ReadLine();

            Console.WriteLine(" Enter a age ");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine(" Enter % ");
            double percentage = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($" name is {name} ");
            Console.WriteLine($" age is {age} ");
            Console.WriteLine($" % is {percentage} ");
        }
    }
    internal class circle
    {
        static void Main(string[] args)
        {
            //Task - accept radius from user and cl=alculate area of circle
            Console.WriteLine(" Enter radius ");
            int r = Convert.ToInt32(Console.ReadLine());

            double PI;
            PI = 3.14;
            double area_of_circle = PI * r * r;
            Console.WriteLine("Area of Circle=" + area_of_circle);

        }
    }
    internal class rectangle
    {
        static void Main(string[] args)
        {
            //Task - accept value L & B calculate area of rectangle
            Console.WriteLine(" Enter length ");
            int L = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter breadth ");
            int B = Convert.ToInt32(Console.ReadLine());

            double area_of_rectangle = L * B;
            Console.WriteLine("Area of rectangle=" + area_of_rectangle);

        }
    }

    internal class square_cube
    {
        static void Main(string[] args)
        {
            //Task - accept number from user & print its square and cube
            Console.WriteLine(" Enter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result1, result2;

            result1 = num * num;
            result2 = num * num * num;

            Console.WriteLine("square of no. is=" + result1);
            Console.WriteLine("cube of no. is=" + result2);
        }
    }
    internal class TotalPercentage
    {
        static void Main(string[] args)
        {

            //TASK = ACCEPT 3 MARKS OF A STUDENT CALCULATE TOTAK AND PERCENTAGE
            Console.WriteLine(" Enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter a number ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter a number ");
            int c = Convert.ToInt32(Console.ReadLine());


            int total = Convert.ToInt32(Console.ReadLine());
            int per = Convert.ToInt32(Console.ReadLine());

            total = a + b + c;
            per = total / 3;

            Console.WriteLine("Total marks=" + total);
            Console.WriteLine("Total percentage=" + per);

        }
    
    }
    internal class BasicOperations
    {
        //perform operations add sub mul div mod
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter a number ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine($" Sum is {sum} ");

            int sub = a - b;
            Console.WriteLine($" Sub is {sub} ");

            int multiply = a * b;
            Console.WriteLine($" Multiplication is {multiply} ");

            double divide = a / b; // 5/2 -- > 2.5 -- > 5 -- > 2 
            Console.WriteLine($" division is {divide} ");

            // explicit type casting
            double div = (double)b; //5.0 / 2 - > 2.5 
            Console.WriteLine($" Div is {div} ");

            int mod = a % b;
            Console.WriteLine($" Mod is {mod} ");
        }
    }
    internal class Addition
    {
        //accept 3 no from user and perform addition
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter a number ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter a number ");
            int c = Convert.ToInt32(Console.ReadLine());

            int sum = a + b + c;
            Console.WriteLine($" Sum is {sum} ");
        }
    }
    internal class swapping
    {
        static void Main(string[] args)
        {
            //Task - Accept the two numbers from user & swap the value using 3rd variable

            Console.WriteLine(" Enter a number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter a number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3;
            num3 = num1;
            num1 = num2;
            num2 = num3;


            Console.WriteLine("1st num  =  " + num1);
            Console.WriteLine("2nd num  =  " + num2);
        }
    }
    internal class swapping1
    {
        static void Main(string[] args)
        {
            //Task - Accept the two numbers from user & swap the value without using 3rd variable
            Console.WriteLine(" Enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter a number ");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a + b;
            a = a - b;

            Console.WriteLine("1st num  =  " + a);
            Console.WriteLine("2nd num  =  " + b);
        }
    }
    internal class OddEven
    {
        static void Main(string[] args)
        {
            //odd even no

            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The no. is even");
            }
            else
            {
                Console.WriteLine("The no. is odd");
            }
        }
    }
    internal class PositiveNegative
    {
        static void Main(string[] args)
        {
            //Task - accept no...check it is +ve, -ve or zero
            Console.WriteLine("  Enter the number ");
            int x = int.Parse(Console.ReadLine());

            if (x > 0)

            {
                Console.WriteLine("The no is positive ");
            }
            else if (x < 0)
            {
                Console.WriteLine("The no is negative ");
            }

            else
            {
                Console.WriteLine("zero");
            }
        }
    }
    internal class salary
    {
        static void Main(string[] args)
        {
            //Task - accept emp id, emp name & basic salary from user
            //calculate hra -> 12% of basic salary
            //da --> 20% of basic, ta --> 10%of basic // pf --> 12% of basic
            //calculate total salary & net paid salary & print it
        }
    }
}
