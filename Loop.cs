using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Loop
    {

          //Loop :--> when we want to execute statement for multiple times based on certain condition, we can use loop
           static void Main(string[] args)
            {

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Hello");
                }


            }

           /* Dry run of program
             i = 1    i <= 10      print-- > Hello   i++
             1        1 <= 10          Hello           2
                       2 <= 10        Hello            3
                       3 <= 10        Hello            4
                       4 <= 10        Hello            5
                      5 <= 10         Hello            6
                      6 <= 10          Hello           7
                      7 <= 10         Hello            8
                      8 <= 10         Hello            9
                      9 <= 10         Hello           10
                     10 <= 10         Hello           11
                     11 <= 10*/
    }
    internal class Loop1
    {
        static void Main(string[] args)
        {
            //WAP to print numbers from 1 - 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class Loop2
    {
        static void Main(string[] args)
        {
            //WAP to print even numbers from 1.- 50

            int i = 0;
            Console.WriteLine("even numbers is : ");
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
    internal class Loop3
    {
        static void Main(string[] args)
        {
            //WAP to print odd numbers from 1 - 50
            int i = 0;
            Console.WriteLine("Odd Numbers : ");
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
    internal class Loop4
    {
        static void Main(string[] args)
        {
            //WAP to print series from 100 - 50
            for (int i = 100; i >= 50; i--)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
    internal class Loop5
    {
        static void Main(string[] args)
        {
            //Accept a number & print its table
            int x;
            Console.WriteLine(" Enter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("table is : ");
            for (int i = 1; i <= 10; i++)
            {
                x = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, x);
            }
        }
    }
    internal class Loop6
    {
        static void Main(string[] args)
        {
            //print 1 to 20 no and also print sum and average
            int i, sum = 0, avg = 0;
            Console.WriteLine("The first 20 no are : ");
            for (i = 1; i <= 20; i++)
            {
                sum = sum + i;
                //avg = sum/20;
                Console.Write("{0} ", i );
            }
            avg = sum / 20;
            Console.WriteLine("sum is=" + sum );
            Console.WriteLine("average is=" +avg );
        }
    }
    internal class Loop7
    {
        static void Main(string[] args)
        {
            //Print number from 1 to 10 & is sum
            int i, sum = 0;
            Console.WriteLine("The first 10 no are : ");
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;           
                Console.Write("{0} ", i);
            }  
            Console.WriteLine("sum is=" + sum);          
        }
    }
}
