using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public class program
    //{
    //    //Property & object initializer syntax in property topic//
    //    static void Main(string[] args)
    //    {

    //        Dept d1 = new Dept();
    //        // property initializer syntax
    //        d1.DeptId = 1;
    //        d1.DeptName = "HR";
    //        d1.Location = "Pune";

    //        // object initializer syntax
    //        Dept d2 = new Dept { DeptId = 2, DeptName = "Sales", Location = "Mumbai" };
    //    }

    //}
    //public class program1
    //{
    //    //Named argument//

    //    static void Main(string[] args)
    //    {

    //        Dept d1 = new Dept(1, "HR", "Pune");
    //        // named argument
    //        Dept d2 = new Dept(location: "Mumbai",deptname: "Sales", deptid: 2);

    //        Dept d3 = new Dept(deptid: 3, deptname: "Admin", location: "Pune");
    //    } 

    //}
    //public class program2
    //{
    //    //Optional & default parameter//
    //    static void Main(string[] args)
    //    {
    //        //isAdmin is an optional parameter
    //        User user1 = new User(1, "Kishor");

    //        User user2 = new User(2, "Rajesh", true);

    //        Console.WriteLine(user1);
    //        Console.WriteLine(user2);
    //    }

    //}


    //
    public class program2
    {
        static void Main(string[] args)
        {
            ICustomer c1 = new Transaction();
            Console.WriteLine(c1.Print());

            IOrder o1 = new Transaction();
            Console.WriteLine(o1.Print());

            Dept dept = new Dept(1, "HR", "Pune");
            Console.WriteLine(dept.Print());
        }


    }

    public class Programpro
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3] { 1, 2, 3 };
            Product[] productlist = new Product[3]
            {
                new Product(101,899,"Mouse"),
                new Product(102,45000,"Dell Laptop"),
                new Product(103,799,"Keyboard")
            };

            // using for loop
            for (int i = 0; i < productlist.Length; i++)
            {
                Console.WriteLine(productlist[i]);
            }

            // using foreach loop

            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }

            foreach (Product prod in productlist)
            {
                Console.WriteLine(prod);
            }

        }
    }
    public class Programbook
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[4] { 1, 2, 3, 4};
            Book1[] booklist = new Book1[4]
            {
                new Book1(101,899,"virat", "kohali"),
                new Book1(102,45000,"rohit" , "sharma"),
                new Book1(103,799,"rishabh", "pant"),
                new Book1(103,799,"ishan", "kisan"),

            };

            // using for loop
            for (int i = 0; i < booklist.Length; i++)
            {
                Console.WriteLine(booklist[i]);
            }

            // using foreach loop

            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }

            foreach (Book1 book in booklist)
            {
                Console.WriteLine(book);
            }

        }
    }
    //public class Programbook2
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr1 = new int[4] { 1, 2, 3, 4 };
    //        Book2[] booklist = new Book2[4]
    //        {
    //            new Book2{id=101,price=899,name="virat", author="kohali" },
    //            new Book2{id=102,price=45000,name="rohit" , author="sharma" },
    //            new Book2{id=103,price=799,name="rishabh",author= "pant" },
    //            new Book2{id=103,price=799,name="ishan", author="kisan" },

    //        };

    //        // using for loop
    //        for (int i = 0; i < booklist.Length; i++)
    //        {
    //            Console.WriteLine(booklist[i]);
    //        }

    //        // using foreach loop

    //        foreach (int item in arr1)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        foreach (Book2 book in booklist)
    //        {
    //            Console.WriteLine(book);
    //        }

    //    }
    //}
}
