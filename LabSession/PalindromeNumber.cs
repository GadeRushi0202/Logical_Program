using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class PalindromeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");             //121
            int num = Convert.ToInt32(Console.ReadLine());   //121

            int rem;
            int result = 0;
            int tem = num;

            while (num != 0)
            {
                rem = num % 10;                           //rem = 121 % 10 = 1   12 % 10 = 2
                result = result * 10 + rem;     //result = 0 + 1 = 1   1+2
                num = num / 10;
            }
            if (tem==result)

            {
                Console.WriteLine("PalindromeNumber");
            }
            else
            {
                Console.WriteLine("Not Palindrome Number");
            }
            

        }
    }
}
