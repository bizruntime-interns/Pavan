using System;
using System.Collections.Generic;

namespace pk
{
    class lister
    {
        private static void Main()
        {
            var thecourses = new List<course>
           {
               new course() {Name="BBA",Duration=3},
               new course() {Name="BE",Duration=4},
               new course() {Name="MBBS",Duration=6},
               new course() {Name="BoA",Duration=5 }
           };
            foreach (course thecourse in thecourses)
            {
                Console.WriteLine(thecourse.Name + "  " + thecourse.Duration);
            }
        }
        public class course
        {
            public string Name { get; set; }
            public int Duration { get; set; }
        }
    }
}