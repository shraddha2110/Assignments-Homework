using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PrefixPostfix
    {
        static void Main(string[] args)
        {
            {
                int a = 10;
                //int b = a++;// assign the value first & then get incremented by 1  b=10,a=11
                int b = ++a;  // first get incremented i.e. by 1 & then assign the value a=11, b=11
                Console.WriteLine($"a= {a}");
                Console.WriteLine($"b= {b}");

            }
        }
    }
    internal class PrefixPostfix1
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = ++a + --a;
            int c = b++ * --a;
            int d = --b * ++c;
            int e = --d * ++a + b++ - a--;
            Console.WriteLine($"a={a}");//9
            Console.WriteLine($"b={b}");//22
            Console.WriteLine($"c={c}");//190
            Console.WriteLine($"d={d}");//3989
            Console.WriteLine($"e={e}");//39901

        }
    }
    internal class PrefixPostfix2
    {
        static void Main(string[] args)
        {
            int a, b;

            a = 5;
            b = 3;
            int x = a++ - --b - a + b++ - a--;

            Console.WriteLine("x=" + x);
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
    internal class PrefixPostfix3
    {
        static void Main(string[] args)
        {
            int i = 4;
            int j = 2;
            int x = i++ + ++j - --i + j-- - i - --j;


            Console.WriteLine("x=" + x);
            Console.WriteLine("i=" + i);
            Console.WriteLine("j=" + j);
        }
    }
    internal class PrefixPostfix4
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 5;
            b = 4;
            c = 3;
            int x = a++ - --b - a + b++ - a--;

            Console.WriteLine("x=" + x);
            Console.WriteLine("a=" + a);
            Console.WriteLine("a=" +a+"b="+b+"c="+c);
            Console.WriteLine(b * 5 / a + b++ + b);
        }
    }
}
