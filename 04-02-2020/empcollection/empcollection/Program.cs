using System;
using System.Collections.Generic;
using System.Text;

namespace empcollectionections
{
    class collection
    {
        public static void Main()
        {
            Dictionary<string, object> ht = new Dictionary<string, object>();
            ht.Add("EmpId", 101);
            ht.Add("EmpName", "Ram");
            ht.Add("Designation", "HR");
            ht.Add("Email", "aaaa@bizruntime.com");
            ht.Add("Salary", 95000);
            ht.Add("PhNo", "1234567890");

            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key + ": " + ht[key]);
            }
        }
    }
}