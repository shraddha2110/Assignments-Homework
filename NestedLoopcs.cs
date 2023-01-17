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
