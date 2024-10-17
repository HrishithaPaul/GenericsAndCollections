using System.Collections.Generic;
namespace TupleBasedKey
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Dictionary<Tuple<string, int>, int> dictTuple = new Dictionary<Tuple<string, int>, int>();
            dictTuple.Add(Tuple.Create("sony", 2), 100);
            dictTuple.Add(Tuple.Create("sunny", 5), 140);
            dictTuple.Add(Tuple.Create("dolu", 6), 473);
            dictTuple.Add(Tuple.Create("bolu", 4), 275);

            foreach(var item in dictTuple)
            {
                Console.WriteLine($"{item.Key.Item1} , {item.Key.Item2} , {item.Value}");
            }
        }
    }
}
