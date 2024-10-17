namespace SortingAndMerging
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

            LinkedList<int> SortedList1 = new LinkedList<int>(list.OrderByDescending(x=>x));
            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(42);
            list2.AddLast(32);
            list2.AddLast(12);
            list2.AddLast(3);
            list2.AddLast(10);

            LinkedList<int> SortedList2 = new LinkedList<int>(list2.OrderByDescending(x => x));
            LinkedList<int> list3 = new LinkedList<int>();
            foreach (var item in SortedList1)
            {
                list3.AddLast(item);
                //Console.WriteLine(item);
            }
            foreach (var i in SortedList2)
            {
                list3.AddLast(i);
                //Console.WriteLine(i);
            }
            foreach (var i in list3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
