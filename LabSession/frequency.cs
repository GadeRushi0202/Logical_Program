using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class frequency
    {
        static void Main(string[] args)
        {
            int num = 3211;
            int copy = num;
            for(int i = 0; i<=9; i++)
            {
                int count = 0;
                while (num > 0)
                {
                    int digit = num % 10;
                    if(digit == i)
                    {
                        count++;
                    }
                    num = num / 10;
                }
                Console.WriteLine(i+" "+count);
                num = copy;
            }
        }
    }
}
