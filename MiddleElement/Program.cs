using System;
namespace MiddleElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(78);
            list.AddLast(89);
            list.AddLast(65);
            list.AddLast(34);
            list.AddLast(224);
            LinkedList<int> SortedList1 = new LinkedList<int>(list.OrderByDescending(x => x));
            foreach (var i in SortedList1)
            {
                Console.WriteLine(i);
            }
            int MiddleEle = SortedList1.Count;
            if (MiddleEle % 2 == 0)
            {
                Console.WriteLine("No Middle Element");
            }
            else
            {
                MiddleEle = MiddleEle / 2 + 1;
                int c = 0;
                //int result = SortedList1.First;
                

                for (LinkedListNode<int> res = SortedList1.First; res !=null ;res=res.Next)
                {
                    c++;
                    if (MiddleEle == c)
                    {
                        Console.WriteLine(res.Value);
                    }
                }
            }
        }
    }
}
