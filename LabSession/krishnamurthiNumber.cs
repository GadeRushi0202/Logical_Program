using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class krishnamurthiNumber
    {
        //WA code to check the number is Krishnamurthi Number or not
        //eg if number digit factorial sum is same as your original number then it is known as the krishnamurthi Number
        //1!+4!+5!
        //1+2fact * i;4+120
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int temp = n;
            int sum = 0;

            while (n != 0)
            {
                rem = n % 10;
                int fact = 1;
                for(int i = 1; i<=rem; i++)
                {
                    fact = fact * i;
                }
                sum = sum * fact;
                n = n / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine(" krishnamurthi Number");
            }
            else
            {
                Console.WriteLine(" Notshnamurthi Number");
            }



        }
    }
}
