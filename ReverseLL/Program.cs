using System;
using System.Collections.Generic;
namespace ReverseLL
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(78);
            list.AddLast(89);
            list.AddLast(65);
            list.AddLast(34);
            list.AddLast(224);
            Console.WriteLine("**********Without Reversing************");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            LinkedList<int> RevList = new LinkedList<int>();
            for (LinkedListNode<int> node = list.Last; node != null; node = node.Previous)
            {
                RevList.AddLast(node.Value);
            }
            Console.WriteLine("**********With Reversing************");
            foreach(var item in RevList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
