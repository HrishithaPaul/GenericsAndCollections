using System;
namespace TupleToDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tuple = Tuple.Create("Sony", "Bobbili");     
            var tuple1 = Tuple.Create("Sunny", "Ashish");     
            var tuple2 = Tuple.Create("Abhi", "Mallika");

            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {tuple.Item1, tuple.Item2 },
                {tuple1.Item1, tuple1.Item2 },
                {tuple2.Item1, tuple2.Item2 }
            };
            foreach(var item in dict)
            {
                Console.WriteLine(item);
            }
        }
    }
}
