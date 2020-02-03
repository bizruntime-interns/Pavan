using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class linqsample
    {
        static void Main()
        {
            int[] scores = new int[] { 10, 18, 19, 24 };

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 15
                select score;
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}

