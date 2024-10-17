using System;
namespace CircularLinkedList
{
    internal class Program
    {
            CircularLinkedList cll = new CircularLinkedList();
        static void Main(string[] args)
        {
            if(IsEmpty)
            {
                cll.InsertAtEnd(10);
                cll.InsertAtEnd(20);
                cll.InsertAtEnd(220);
                cll.InsertAtEnd(230);
                cll.InsertAtEnd(325);
                cll.InsertAtEnd(2);
            }
            else{
                cll.DeleteFirst();
                cll.DeleteLast();
            }
            Console.WriteLine(cll.Display())

            foreach(var item in cll)
            {
                Console.WriteLine(item.Search(20));
            }
        }
    }
}
