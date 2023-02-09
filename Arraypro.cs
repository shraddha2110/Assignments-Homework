using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Arraypro
    {
        static void Main(string[] args)
        {
            //Display maximum number from array of 10 numbers

            int[] array = { 10, 20, 55, 101, 60, 200, 30, 8, 90, 110 };
            int max = array[0];
            int min = array[0];
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
    //op
    //200
    //Press any key to continue . . .

    internal class Arraypro1
    {
        //Check if given number is Armstrong or not.
        public static void Main(string[] args)
        {
            int r1, sum = 0;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            while (num != 0)
            {
                r1 = num % 10;
                sum = sum + (r1 * r1 * r1);
                num = num / 10;
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
    //op
    //Enter a number
    //5
    //Not Armstrong number
    //Press any key to continue . . .

    //Enter a number
    //153
    //Armstrong number
    //Press any key to continue . . .

    internal class Arraypro2
    {
        static void Main(string[] args)
        {
            //Sort array of 5 integers

            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            Array.Sort(arr);
            Console.WriteLine("sorting array");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

        }
    }
    //op
    //sorting array
    //1 5 6 7 9 9 Press any key to continue . . .

    internal class Arraypro3
    {
        //Calculate factorial of a number.
        static void Main(string[] args)
        {
            int i, fact = 1, num;
            Console.WriteLine("Enter the no");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + num + " is: " + fact);
        }
    }
    //op
    //Enter the no
    //3
    //Factorial of 3 is: 6
    //Press any key to continue . . .

    internal class Arraypro4
    {
        //Reverse an array of 5 numbers.
        static void Main(string[] args)
        {
            //int[] list = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //int[] temp = list;

            //Array.Reverse(temp);
            //Console.Write("Reversed Array  ");
            //foreach (int i in temp)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();


            int[,] arr1 = new int[4, 3];
            Console.WriteLine("[0,0]: " + arr1[0, 0]);
            Console.WriteLine("[0,1]: " + arr1[0, 1]);
            Console.WriteLine("[0,2]: " + arr1[0, 2]);
            Console.WriteLine("[1,0]: " + arr1[1, 0]);

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.WriteLine($"arr1[{i},{j}]={arr1[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
    //op
    //Reversed Array  50 45 40 35 30 25 20 15 10 5
    //Press any key to continue . . .
    internal class Arraypro2d
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[4, 3];
            Console.WriteLine("[0,0]: " + arr1[0, 0]);
            Console.WriteLine("[0,1]: " + arr1[0, 1]);
            Console.WriteLine("[0,2]: " + arr1[0, 2]);
            Console.WriteLine("[1,0]: " + arr1[1, 0]);

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.WriteLine($"arr1[{i},{j}]={arr1[i, j]}");
                }
                Console.WriteLine();
            }
        }


    }
    public class Product
    {
        private int id, price;
        private string name;
        public Product(int id, int price, string name)
        {
            this.id = id;
            this.price = price;
            this.name = name;
        }
        public override string ToString()
        {
            return $"Id = {id} , Name ={name}, Price={price}";
        }
    }

    public class Book1
    {
        private int id, price;
        private string name;
        private string author;
        public Book1(int id, int price, string name, string author)
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.author = author;
        }
        public override string ToString()
        {
            return $"Id = {id} , Name ={name}, Price={price} , Author ={ author}";
        }
    }

    //public class Book2
    //{
    //    private int id, price;
    //    private string name;
    //    private string author;
    //    public Book2(int id, int price, string name, string author)
    //    {
    //        //this.id = id;
    //        //this.price = price;
    //        //this.name = name;
    //        //this.author = author;

    //        public int id { get; set; }
    //    public int price { get; set; }
    //    public string name { get; set; }
    //    public string author { get; set; }

    //}
    //public override string ToString()
    //{
    //    return $"Id = {id} , Name ={price}, Price={name} , Author ={author}";
    //}
}
internal class Arraypro3d
    {
    //Working with Built in class “Array”

    static void Main(string[] args)
    {
        int[] arr1 = new int[] { 78, 34, 8, 1, 2, 4, 9, 67, 45, 23 };

        int[] arr2 = new int[10] { 10, 20, 30, 40, 50, 0, 0, 0, 0, 0 };
        foreach (int item in arr1)
        {

            Console.WriteLine(item);

        }

        //C# provides built in class called Array

        // Array.Sort(arr1);

        //Array.Sort(arr1, 2, 6);

        //Array.Reverse(arr1); // Array.Clear(arr1, 4, 3);

        //Array.Copy(arr1, arr2, 5);
        Array.Copy(arr1, 2, arr2, 5, 5);

        Console.WriteLine("Arr2");

        foreach (int item in arr2)
        {
            Console.WriteLine(item);
        }

    }

}

internal class Arraypro4d
{
    //Working with Built in class “Array”

    static void Main(string[] args)
    {
        string[] names = { "Maya", "Monisha", "Rosesh", "Sahil", "Himanshu" };
        Array.Sort(names);

        foreach (string item in names)
        {

            Console.WriteLine(item);

        }

        //C# provides built in class called Array

        // Array.Sort(names);

        //Array.Sort(names, 2, 6);

        //Array.Reverse(names); // Array.Clear(names, 4, 3);

        //Array.Copy(names, names, 5);
        Array.Copy(names, 2, names, 5, 5);

        Console.WriteLine("names");

        foreach (string item in names)
        {
            Console.WriteLine(item);
        }

    }
    internal class ArrayListpro
    {
        //static void Main(string[] args)
        //{
        //    int[] arrl = new int[] { 1, 2, 3, 4, 5 };

        //    ArrayList list = new ArrayList();

        //    list.Add(10); // implicit boxing

        //    list.Add("Pune");

        //    list.Add(4.5);

        //    list.Insert(0, "Maharashtra");

        //    list.AddRange(arr1);

        //    list.Add(100);

        //    // list.Remove(4.5);

        //    //list.RemoveRange(1, 3);

        //    //list.RemoveAt(4);

        //    //list.Clear();

        //    Console.WriteLine($"total elements {list.Count}");

        //    Console.WriteLine($"capacity of arraylist {list.Capacity}");

        //    foreach (var item in list)
        //    {

        //        Console.WriteLine(item);
        //    }
        //}
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            ArrayList list = new ArrayList();
            list.Add(10); // implicit boxing
            list.Add("Pune");
            list.Add(4.5);

            list.Insert(0, "Maharashtra");

            list.AddRange(arr1);
            list.Add(100);
            // list.Remove(4.5);
            // list.RemoveRange(1, 3);

            // list.RemoveAt(4);
            list.Clear();
            Console.WriteLine($"total elements {list.Count}");
            Console.WriteLine($"capacity of arraylist {list.Capacity}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
    internal class ArrayproList
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                ArrayList products = new ArrayList()
            {
                new Product{Id=1,Name="mouse",Price=899},
                new Product{Id=2,Name="keyboard",Price=699},
                new Product{Id=3,Name="laptop",Price=34899},
                new Product{Id=4,Name="Pendrive",Price=1299},
                new Product{Id=5,Name="DVD",Price=99},
            };
                //               OR
                ArrayList productlist = new ArrayList();
                productlist.Add(new Product { Id = 1, Name = "mouse", Price = 899 });
                productlist.Add(new Product { Id = 2, Name = "keyboard", Price = 699 });
                productlist.Add(new Product { Id = 3, Name = "laptop", Price = 34899 });

                foreach (Product item in products)
                {
                    if (item.Price >= 1000)
                    {
                        Console.WriteLine($"{item.Id}- {item.Name} - {item.Price}");
                    }

                }
                Console.WriteLine("-------------------------------");
                foreach (Product item in productlist)
                {
                    Console.WriteLine($"{item.Id}- {item.Name} - {item.Price}");
                }
            }
        }
    }
    internal class ArrayproList12
    {
        //Create a student class with rollno, name & percentage

        //Create an arraylist of 5 students
        //Print all students using foreach

        //Print students those whose are pass

    }
    internal class ArrayproList13
    {
        //Generic Collections in C#
         static void Main(string[] args)
        {
            List<int> ilist = new List<int>();
            ilist.Add(1);
            ilist.Add(2);
            ilist.Add(3);
            // insert, addrange,removerange,remove, removeat,sort , reverse, -> count ,capacity
            List<string> slist = new List<string>();
            slist.Add("Pune");
            slist.Add("Mumbai");

            foreach (string item in slist)
            {
                Console.WriteLine(item);
            }
            List<Product> productlist = new List<Product>();
            //productlist.Add(new Product { Id = 1, Name = "mouse", Price = 899 });

            foreach (Product p in productlist)
            {
                Console.WriteLine();
            }
            List<double> dlist = new List<double>();
            dlist.Add(45222.787);

            foreach (int i in ilist)
            {
                Console.WriteLine(i);
            }

            Stack<int> stack = new Stack<int>();    
            //Push ,Pop, Peek

            Queue<string> queue = new Queue<string>();
            //Enqueue, Dequeue,peek

            Dictionary<int, string> dictionary = new Dictionary<int, string>(); 
            dictionary.Add(91, "IND");
            dictionary.Add(65, "AUS");

            // Remove

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        } 
    }
    internal class hashset
    {
        static void Main(string[] args)
        {
            HashSet<string> set1 = new HashSet<string>();

            set1.Add("C");
            set1.Add("C++");
            set1.Add("C#");
            set1.Add("Java");
            set1.Add("Ruby");

            HashSet<string> set2 = new HashSet<string>();

            set2.Add("PHP");
            set2.Add("C++");
            set2.Add("Perl");
            set2.Add("Java");

            // union on hastset
            // set1.UnionWith(set2);
            //  set1.IntersectWith(set2);
            set1.ExceptWith(set2);
            foreach (string s in set1)
            {
                Console.WriteLine(s);
            }
        }

    }
}
