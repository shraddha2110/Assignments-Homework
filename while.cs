using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class @while
    {

        static void Main(string[] args)
        {   
            int i = 1; // initial value
            while (i <= 10) //entry control loop
            {
                Console.WriteLine($"{i}");
                i++;
            }
        }

    }
    internal class @while1
    {
        static void Main(string[] args)
        {
            //WAP to print even numbers from 1.- 50

            int i = 0;
            Console.WriteLine("even numbers is : ");
            while(i<=50)
            {              
                    Console.WriteLine(i + " ");
                    i=i+2;           
            }
        }
    }
    //internal class @while2
    //{
    //    static void Main(string[] args)
    //    {
    //        //WAP to print odd numbers from 1 - 50
    //        int i = 0;
    //        Console.WriteLine("Odd Numbers : ");
    //        while(i<=50)
    //        //for (i = 1; i <= 50; i++)
    //        {
    //            if (i % 2 != 0)
    //            {
    //                Console.WriteLine(i + " ");
    //                i = i + -1;
    //            }
    //        }
    //    }
    //}
    internal class @do_while
    {
        static void Main(string[] args)
        {
            int z = 0;
            do
            {
                Console.WriteLine("Enter two numbers");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Multi");
                Console.WriteLine("select your option");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine($"Addition is {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"Sub is {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"Multiplication is {a * b}");
                        break;
                    default:
                        Console.WriteLine("Wrong option selection");
                        break;
                }
                Console.WriteLine("Select 1 for continue and 0 for exit");
                z = Convert.ToInt32(Console.ReadLine());
            } while (z == 1);
        }

    }
    internal class @do_while1
    {
        //WAP to print numbers from 1 - 10
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
        }
    }
    internal class @do_while2
    {
        //WAP to print even numbers from 1.- 50
        static void Main(string[] args)
        {

            int i= 1;
            do
            {

                //i % 2 == 0;
                Console.WriteLine(i + " ");
                i++;
                   
            }
            while (i<=50);
        }
    }
    internal class @do_while3
    {
        //WAP to print odd numbers from 1 - 50
        static void Main(string[] args)
        {

        }
    }
    internal class @do_while4
    {
        //WAP to print series from 100- 50
        static void Main(string[] args)
        {

        }
    }
    internal class @do_while5
    {
        //Accept a number & print its table
        static void Main(string[] args)
        {

        }
    }
    internal class @do_while6
    {
        //Print number from 1 to 10 & is sum

        static void Main(string[] args)
        {

        }
    }
    internal class @do_while7
    {
    //    WAP to accept a 3 digit number from user & print in reverse order using while loop
    //    Input : 123
    //    Output :321

        static void Main(string[] args)
        {
            int r1, reverse = 0;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine()); //234
            while (num != 0)
            {
                r1 = num % 10; // r1=2
                reverse = reverse * 10 + r1;// 430+2 -> 432
                num = num / 10; // 2/10 -> 0

            }
            Console.WriteLine(reverse);

        }
    }
    internal class while8
    {
        //Accept a 3 digit number from user & check number is armstrong number or not
        //153  = (1*1*1)+(5*5*5)+(3*3*3)
        //Solve using while loop

        static void Main(string[] args)
        {
            int r1, sum = 0;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());// 153
            int temp = num;// temp=153
            while (num != 0)
            {
                r1 = num % 10; // r1=1
                sum = sum + (r1 * r1 * r1); //0+27= 27 + = 152+1 =153
                num = num / 10; //1
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not Armstrong number");
            }

        }
    }
    internal class while9
    {
        //WAP to accept a number from user & check entered number is prime num or not
        static void Main(string[] args)
        {
            //int n, i, count = 0;
            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
           
            //i = 2;
            //while (i<=n/2)
            //{
            //    if (n % i == 0)
            //    {
            //        count = 1;
                    
            //    }
            //    ++i;
            //}
            //if (count == 0)
            //    Console.WriteLine("Prime number");
            //else
            //    Console.WriteLine("Not Prime number");
        }
    }

}
