using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Homework
    {

        //static void Main(string[] args)
        //{
        //    //Print number from 1 to 10 & is sum
        //    int i, sum = 0;
        //    Console.WriteLine("The first 10 no are : ");
        //    for (i = 1; i <= 10; i++)
        //    {
        //        sum = sum + i;
        //        Console.Write("{0} ", i);
        //    }
        //    Console.WriteLine(" sum is=" + sum);
        //}

        public static void MaximumArray()
        {
            int[] array = { 10, 30, 40, 100, 170, 50, 20, 60 };
            int max = array[0];
            
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }             
            }
            Console.WriteLine(max);
        }
    }
}
