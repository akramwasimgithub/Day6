using System;

namespace Day6
{
    class Program
    {
        static void Main(String[] args)
            
        {
            int num1 = 0, num2 = 1, thirdNum = 0;
            Console.Write("Enter the length fibonacci series you want :");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.Write(" required series {0} {1} ", num1, num2);
            
            
            for (int i=2;i<len;i++)
            {
                thirdNum = num1 + num2;
                Console.Write("{0} "  ,  thirdNum);
                num1 = num2;
                num2 = thirdNum;

            }
        }
       
            
    }
}
