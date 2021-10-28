using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class reverseNumber
    {
        static void Main(String[] args)

        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n =n/ 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}