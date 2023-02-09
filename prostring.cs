using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class prostring
    {
        static void Main(string[] args)
        {
            string name = "Test";

            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            string msg = new string(chars);
            Console.WriteLine(msg);

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + " ");
            }

            string str1 = "apple";
            string str2 = "Good Afternoon";
            string str4 = string.Empty;
            //or
            string str5 = "";
            string str6 = null;
            string str3 = String.Concat(str1, " ", str2);
            Console.WriteLine(str3);

            // to check whether word or a character is present in the given string
            // contains method returns true if word is present and returns false if not present
            bool result = str2.Contains('G');
            Console.WriteLine(result);

            // Equals check for the value , if both have same value based on ASCII then return same else different
            //if (str1.Equals(str4))
            //{
            //    Console.WriteLine("Both strings are same");
            //}
            //else
            //{
            //    Console.WriteLine("Both strings are different");
            //}


            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
            // which converts string to char array
            char[] ch = str2.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }

            if (String.IsNullOrEmpty(str4))
            {
                Console.WriteLine("str4 is empty or null");
            }
            else
            {
                Console.WriteLine($"str4 = {str4}");
            }

            Console.WriteLine(str2.ToUpper());
            Console.WriteLine(str2.ToLower());
            // trim function remove the spaces before & after the sting
            str2.Trim();
            // TrimEnd() removes the spaces after the string
            str2.TrimEnd();
            //TrimStart() remvoes teh spaces which is before the string
            str2.TrimStart();

            string newstring = str2.Substring(5, 5);
            Console.WriteLine(newstring);
        }
    }
    internal class prostringbuilder
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Think Quotient");
            stringBuilder.Append("Welcome all");
            float salary = 45000.45F;
            stringBuilder.AppendFormat("Current Salary is {0:C}", salary);
            // stringBuilder.Clear();
            stringBuilder.Remove(10, 4);
            stringBuilder.Replace('T', 't');
            stringBuilder.Replace("all", "everyone");
            Console.WriteLine(stringBuilder);

        }
    }
    internal class prostringbuilder1
    {
        static void Main(string[] args)
        {
            //string is immutable --> can not be change 
            //stringbuilder it is mutable --> can be change

            string str1 = "Hello";
            Console.WriteLine(str1.GetHashCode()); 
            str1 = str1 + "welcome all"; 
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());

            StringBuilder stringBuilder = new StringBuilder("Hello");

            Console.WriteLine(stringBuilder.GetHashCode()); 
            stringBuilder.AppendLine("welocme all");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.GetHashCode());
        }
    }
}
