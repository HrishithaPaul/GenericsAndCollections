using System;
namespace SwappingElements
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 5, 2, 7, 3 };
            //list.Add(10);
            //list.Add(20);
            //list.Add(10);
            //list.Add(50);
            //list.Add(10);

            SwapEle(list, 2, 3);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine("Hello, World!");
        }

        public static void SwapEle(List<int> list , int node1, int node5)
        {
            if (node1 != null || node5 != null)
            {
                int temp = list[node5];
                list[node5]= list[node1];
                list[node1]= temp;
            }
            
        }
    }
}
