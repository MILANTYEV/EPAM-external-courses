using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static T GetRemainingFromList<T>(List<T> list, int N)
        {
            while (list.Count != 1)
            {
                if (list.Count < N)
                {
                    list.RemoveAt((N-1) % list.Count );
                }
                else
                {
                    list.RemoveAt(N - 1);
                }
            }
            return list[0];
        }

        static T GetRemainingFromLinkedList<T>(LinkedList<T> list, int N)
        {
            while (list.Count != 1)
            {
                var node = list.First;
                int deleteIndex = (list.Count < N)
                    ? (N - 1) % list.Count
                    : N - 1;
                for (int i = 1; i <= deleteIndex; i++)
                {
                    node = node.Next;
                }
                list.Remove(node);
            }
            return list.First.Value;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of lists");
            int length = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            LinkedList<string> linkedList = new LinkedList<string>();
            string element;
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine("Enter {0} element of lists", i);
                element = Console.ReadLine();
                list.Add(element);
                linkedList.AddLast(element);
            }
            Console.WriteLine("Enter the remove elements number");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Remaining element\nFrom list:{0}\nFrom Linked list:{1}",
                GetRemainingFromList(list,N), GetRemainingFromLinkedList(linkedList, N));
            Console.ReadKey();
        }
    }
}
