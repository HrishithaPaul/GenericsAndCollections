using System;
namespace GenericStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(28);
            s.Push(65);
            s.Push(54);
            s.Push(95);
            s.Push(83);
            Console.WriteLine("Before popping elements: ");

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After popping the elements: ");
            s.Pop();
            s.Pop();

            foreach(var i in s)
            {
                Console.WriteLine(i);
            }
        }
    }
}