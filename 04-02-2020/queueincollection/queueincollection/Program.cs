using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace queueincollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("1 in Queue : {0}",queue.Contains(1));
            Console.WriteLine("Remove 1 : {0}", queue.Dequeue());
            Console.WriteLine("Peek : {0}", queue.Peek());

            object[] numArray = queue.ToArray();

            Console.WriteLine(String.Join(",", numArray));

            queue.Clear();


            foreach (object o in queue)
            {
                Console.WriteLine("$Queue : {o}");
            }

            Console.ReadLine();
        }
    }
}
