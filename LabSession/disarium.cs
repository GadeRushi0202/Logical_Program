using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class disarium
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine()); //135

            int temp = num;
            int rem;
            int sum = 0;
            int count = 0;

            while(num > 0)    //135>0
            {
                count++;            
                num = num / 10;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
                
            }
            num = temp;
            while (num > 0)
            {
                int digit = num % 10;
                int power = 1;
                for(int i = 1; i<= count; i++)
                {
                    power = power * digit;
                }
                sum = sum + power;
                count--;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("disarium");
            }
            else
            {
                Console.WriteLine("Not disarium");
            }

            
        }
    }
}
