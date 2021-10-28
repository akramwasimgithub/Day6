using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class primeNumber
    {
        static void Main(String[] args)
        {
            int a = 0;
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", n);
            for (int i = 2; i < (n / 2); i++)
            {
                if (n % i == 0)
                {
                   /* Console.WriteLine("{0}", i);*/
                    a = 1;
                    
                }
            }
                    if (a == 0)
                    {
                        Console.WriteLine(" is a Prime Number", n);
                    }
                    else
                    {
                        Console.WriteLine(" Not a Prime Number");
                    }
                }
            }
        }
 

