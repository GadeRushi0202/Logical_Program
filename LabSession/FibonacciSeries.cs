using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < 10; i++)  // i = 0; 0 < 10; 1;   1<10; 2;    2<10; 3;   3<10; 4;   4<10; 5
            {
                int c = a + b;           // c = 0+1=1            1+1=2       1+2=3      2+3=5      3+5=8
                a = b;                   // 0=1                  1=1         1=2        2=3        3=5
                b = c;                   // 1=1                  1=2         2=3        3=5        5=8
                Console.WriteLine(c);
            }
        }
    }
}
