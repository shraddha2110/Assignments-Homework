using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Switch_Operations
    {
        //Task6 - accept two no from user
        //place options 1. add 2. sub 3. mul 4. div 5. mod
        //based on user selection perform the arithmatic operation, display result
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1st no");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd no");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1. add 2. sub 3. mul 4. div 5. mod");
            Console.WriteLine("select ur option from 1 to 5");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("add=" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("sub=" + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("mul=" + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("div=" + (num1 / num2));
                    break;
                case 5:
                    Console.WriteLine("mod=" + (num1 % num2));
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }
        }
    }
    internal class Switch_Basic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. English");
            Console.WriteLine("2. Hindi");
            Console.WriteLine("3. Marathi");
            Console.WriteLine("Select your option from 1- 3");
            int option = Convert.ToInt32(Console.ReadLine()); //1
            switch (option) //2
            {
                case 1:
                    Console.WriteLine("You have selected English Lang");
                    break;
                case 2:
                    Console.WriteLine("You have selected Hindi Lang");
                    break;
                case 3:
                    Console.WriteLine("You have selected Marathi Lang");
                    break;
                default:
                    Console.WriteLine("Wrong option selection");
                    break;
            }

        }
    }
    internal class Switch_Basic3
    {

    }
}
