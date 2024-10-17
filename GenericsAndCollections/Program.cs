//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace GenericsAndCollections
//{
//    public class Program
//    {

//        static void Main(string[] args)
//        {
//            LinkedList<int> list1 = new LinkedList<int>();
//            list1.AddLast(10);
//            list1.AddLast(20);
//            list1.AddLast(10);
//            list1.AddLast(50);
//            list1.AddLast(10);

//            LinkedList<int> n = RemoveDup(list1);
//            foreach (int item in n)
//            {
//                Console.WriteLine(item);
//            }

//        }
//        public static LinkedList<int> RemoveDup(LinkedList<int> list)
//        {
//            LinkedList<int> n = new LinkedList<int>();
//            foreach (var i in list)
//            {
//                if (!n.Contains(i))
//                    {
//                    n.AddLast(i);
//                }
//            }
//            return n;
//        }
//    }
//}         
            //for (LinkedList<int> node = list1.First; node = list1.Next; node = node.Next)
            //LinkedListNode<int> i = current.Foirst;

            //for (LinkedListNode<int> currentNode = list1.First; currentNode != null; currentNode = currentNode.Next)

            //{
            //    //Console.WriteLine(currentNode.Value);
            //}

            //int a = 10;
