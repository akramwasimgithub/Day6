﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class PerfectNumber
    {
        static void Main(String[] args)
        {
            int n, i, sum;

          
            Console.Write("Check whether a given number is perfect number or not: ");
            
          

            Console.Write("Input the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The positive divisor  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.Write("\nThe sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.Write("\nSo, the number is perfect.");
            else
                Console.Write("\nSo, the number is not perfect.");
            Console.Write("\n");
        }


    }




}

