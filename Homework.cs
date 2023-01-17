using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Homework
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
            Console.WriteLine(" sum is=" + sum);
        }
    }
}
