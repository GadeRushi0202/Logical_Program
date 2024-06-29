using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class prime11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a NUmber");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a NUmber");
            int i = Convert.ToInt32(Console.ReadLine());

            for (num = 1; num <= 100; num++)
            {
                int count = 0;
                for ( i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
