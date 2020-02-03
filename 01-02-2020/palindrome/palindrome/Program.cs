using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Give a num");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = n%10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a palindrome");
        }
    }
}
