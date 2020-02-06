using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace arreycollection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList code
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add("Alice");

            Console.WriteLine("Count: {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            aList.AddRange(aList);
            aList2.Sort();
            aList2.Reverse();
            
            aList2.Insert(1, "India");
            ArrayList range = aList2.GetRange(0, 2);

            foreach(object o in aList2)
            {
                Console.WriteLine(o);
            }

            #endregion
            Console.ReadLine();
        }
    }
}
