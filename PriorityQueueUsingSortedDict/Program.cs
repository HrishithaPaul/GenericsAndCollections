using System;
using System.Collections.Generic;
namespace PriorityQueueUsingSortedDict
{
    public class Program
    {


        static void Main(string[] args)
        {
            PriorityQueue<string, int> ele = new PriorityQueue<string, int>();
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            dict.Add("Sony", 3);
            dict.Add("Sunny", 1);
            dict.Add("Ashu", 2);


            foreach (KeyValuePair<string, int> i in dict)
            {
                ele.Enqueue(i.Key, i.Value);
            }
            Console.WriteLine(ele.Dequeue());
        }
    }
}
