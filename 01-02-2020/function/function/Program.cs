using System;

namespace function
{
    class Program
    {
        public string Show(string message)
        {
            return message;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            string message = program.Show("Rahul Naidu");
            Console.WriteLine("Hey.. " + message);
        }
    }
}
