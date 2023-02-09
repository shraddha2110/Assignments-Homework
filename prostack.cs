using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class prostack
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // stack.Pop();
            //stack.Pop();
            Console.WriteLine($"top element in the stack {stack.Peek()}");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
    internal class proqueue
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // queue.Dequeue();
            Console.WriteLine($"total elements {queue.Count}");
            Console.WriteLine($"first element in the queue {queue.Peek()}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
    internal class prohashtable
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(91, "IND");
            hashtable.Add(65, "AUS");
            hashtable.Add(1, "USA");
            hashtable.Add(2, "UK");
            hashtable.Add(4.5, "Test");
            hashtable.Add("Test2", 67.77);

            hashtable.Remove("Test2");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }
        }
    }
    internal class prohashtable1
    {
        static void Main(string[] args)
        {
            //Write hashtable code to display mobile number & its name
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1234567897, "ROHIT");
            hashtable.Add(234567891, "VIRAT");
            hashtable.Add(345678912, "RAHUL");
            hashtable.Add(456789123, "CHAHAL");
            hashtable.Add(852741963, "SACHIN");
            hashtable.Add("RISHABH", 741852963);

            hashtable.Remove("SACHIN");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }
        }
    }
    internal class prosortedlist
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(91, "IND");
            sortedList.Add(65, "AUS");
            sortedList.Add(1, "USA");
            sortedList.Add(2, "UK");

            //sortedList.Remove(2);
            sortedList.Add(20, "Test");
            Console.WriteLine("Total elements " + sortedList.Count);
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
    }
    internal class prosortedlist1
    {
        //HW - Add contact & name using sorted list
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(9140520205, "RITIKA");
            sortedList.Add(6585857421, "ANUSHKA");
            sortedList.Add(1234567898, "POOJA");
            sortedList.Add(2741963852, "KEERTHI");

            //sortedList.Remove(2);
            sortedList.Add(50.00, "Test");
            Console.WriteLine("Total elements " + sortedList.Count);
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }

        //HW - Create an arraylist add numbers in to it & use method like a. sort(), b. Reverse()
    }
}
