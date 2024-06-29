using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class AvgDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            
            int count = 0;
            int sum = 0;
            int avg;

            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                count++;
                num = num / 10;

                
            }
            avg = sum / count;
            Console.WriteLine(avg);
            
        }
    }
}
