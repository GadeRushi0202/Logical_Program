using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:-");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + rem;

                num = num / 10;
            }
            if(num % 2 != 0)
            {

            }
        }
    }
}
