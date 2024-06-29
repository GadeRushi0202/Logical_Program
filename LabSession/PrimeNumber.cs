using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");       //7
            int num = int.Parse(Console.ReadLine());   //7
            int count = 0;                                            //1
            for(int i = 1; i <= num; i++)              //i=1 ; 1 <= 7; i++ =2;
                                                       //       2  <= 7;     3;    --true
                                                       //       3  <= 7;     4;    --true
                                                       //       4  <= 7;     5;     --true
                                                       //       5  <= 7;     6;     --true
                                                       //       6  <= 7;     7;     --true
                                                       //       7  <= 7;     8;     --true
                                                       //       8  <= 7;            ---false
            {
                if (num % i == 0)                       //(7 % 1 == 0) = 0 --true
                                                       //(7 % 2 == 0) = 1 -- flase
                                                       //(7 % 3 == 0) = 1 -- flase
                                                       //(7 % 4 == 0) = 3 -- flase
                                                       //(7 % 5 == 0) = 2 -- flase
                                                       //(7 % 6 == 0) = 1 -- flase
                                                       //(7 % 7 == 0) = 0 -- flase
                {
                    count++;                           // count++ = 1+1 =2
           
            }
            }
            if (count == 2)                             // 2 == 2
            {
                Console.WriteLine("prime");     //prime
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
