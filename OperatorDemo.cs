using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OperatorDemo
    {
        static void Main(string[] args)
        {
            //<,>,<=,>=,!=,==
            int p, q, r;
            p = 15;
            q = 11;
            r = 6;

            Console.WriteLine(p > q);//true
            Console.WriteLine(p < r);//false
            Console.WriteLine(q > r);//true
            Console.WriteLine(r < p);//true

            Console.WriteLine(p >= q);//true
            Console.WriteLine(p <= q);//false

            Console.WriteLine(q != r);//true

            Console.WriteLine(p == q);//false

            //logical && || !
            Console.WriteLine(p > q && p > r);
            Console.WriteLine(q < r || q > p);
            Console.WriteLine(!(p < q));



            //+=, -=, *=, /=
            p = 15;
            p += 3;//p+3=18
            Console.WriteLine(p);
            p -= 10;//p-10=8
            Console.WriteLine(p);
            p *= 5;//p*5=40
            Console.WriteLine(p);
            p /= 3;//p/3=13
            Console.WriteLine(p);
        }
    }
    internal class OperatorDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));

            Console.WriteLine(4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - 91.0 / 11));
        }
    }
    internal class OperatorDemo2
    {
        static void Main(string[] args)//assignment
        {
            int a = 10, b = 10, c = 10, d = 10;
            a += 10;  // a=a+10;
            b -= 5;  // b=b-5
            c *= 5;  // c=c*5
            d /= 2; // d=d/2
            Console.WriteLine($"value of a {a}");
            Console.WriteLine($"value of b {b}");
            Console.WriteLine($"value of c {c}");
            Console.WriteLine($"value of d {d}");
        }
    }
    internal class OperatorDemo3
    {
        static void Main(string[] args)//relational
        {
            int a = 9, b = 9;

            Console.WriteLine(a < b); // 9<9 
            Console.WriteLine(a <= b); // 9<=9
            Console.WriteLine(a > b);  // 10>9
            Console.WriteLine(a >= b); //10 >=9
            Console.WriteLine(a == b); // 10==9
            Console.WriteLine(a != b); // 10!=9


        }
    }
    internal class OperatorDemo4//logical
    {
        static void Main(string[] args)//
        {
            // int a=10,b=9 , c=12;
            //                7<9 && 7<8
            //Console.WriteLine(a<b && a<c);
            //                 T   T    T
            //          person=="India" &&   age>=18
            // he / she can vote

            // Console.WriteLine( a < b || a < c);

            //          id=="aadhar"  || id=="election" || id="pan card"

            bool test1 = false;

            bool test2 = !test1;

            Console.WriteLine(test2);

        }
    }
}

