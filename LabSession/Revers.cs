using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class Revers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());  //123
            int rem;
            int result = 0;

            while(num != 0)               // num != 0 = 123 != 0 ;     12 != 0;               1 != 0
            {
                rem = num % 10;           //rem = 123 % 10; = 3         12 % 10 = 2           1% 10 = 1
                result = result * 10 + rem; // result = 0*10+3= 3       3 * 10 + 2 =  32      32 * 10 +1 = 321
                num = num / 10;             //num = 123/10 = 12         12/10 = 1             1/10= 0
            }
            Console.WriteLine(result);
        }
    }
}
