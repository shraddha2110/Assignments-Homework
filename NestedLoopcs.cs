using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NestedLoopcs
    {
        static void Main(string[] args)
        {
            // outer for loop which can be used for no. rows
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 5; j++) // column
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

    }
        //Op
        //*****
        //*****
        //*****
        //*****
    internal class NestedLoop1
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; --i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    //op
    //*****
    //****
    //***
    //**
    //*
    internal class NestedLoop2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    //op
    //*
    //**
    //***
    //****
    //*****
    internal class NestedLoop21
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 8; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    internal class NestedLoop22
    {
        static void Main(string[] args)
        {
            int val = 5;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }

    internal class NestedLoop23
    {
        static void Main(string[] args)
        {
            var num = 5;
            for (var i = -num; i <= num; i++)
            {
                var k = i;
                if (k < 0)
                {
                    k = k * -1;
                }
                for (var j = 0; j <= num; ++j)
                {
                    if (j < k)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    internal class NestedLoop3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    //op
    //1
    //12
    //123
    //1234
    //12345
    internal class NestedLoop4
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; --i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    //op
    //12345
    //1234
    //123
    //12
    //1
    internal class NestedLoop5
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    //op
    //54321
    //4321
    //321
    //21
    //1
    internal class NestedLoop6
    {
        //          *
        //      *     *
        //  *      *    *
        //*    *     *     *

        //static void main(string[] args)
        //{
        //    for (int i = 1; i <= 4; ++i)
        //    {
        //        for (int j = 1; j <=i; ++j)
        //        {
        //            console.write("  *  ");
        //        }
        //        console.writeline();
        //    }
        //}
    }
}
