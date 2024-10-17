using System;
namespace GenericQueue
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

            Queue<int> queue = new Queue<int>(list);
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
