using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class KaprekarNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number;");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sq = num * num;
            int copy = num;
            while (num >0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for(int i = 1; i <= count; i++)
            {
                power = power * 10;
            }
            int end = sq % power;
            int start = sq / power;
            int result = end + start;
            Console.WriteLine(result);
            if(result == copy)
            {
                Console.WriteLine("KaprekarNumber");
            }
            else
            {
                Console.WriteLine("not KaprekarNumber");
            }
        }
        
    }
}
