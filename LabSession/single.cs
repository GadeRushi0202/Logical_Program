using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class single
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num >= 0 && num <= 9)
            {
                Console.WriteLine("sigle digit");
            }
            else if(num >= 10 && num <= 99)
            {
                Console.WriteLine("double digit");
            }
            else if (num >= 100 && num <= 999)
            {
                Console.WriteLine("Triple digit");
            }
            else
            {
                Console.WriteLine("More than  three digit");
            }
        }
    }
}
