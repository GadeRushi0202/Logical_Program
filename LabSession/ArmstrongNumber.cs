using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class ArmstrongNumber
    {    //write to accept a number from user and check number is armstrong number 
        static void Main(string[] args){
            Console.WriteLine("Enter a Number:-");
            int num = Convert.ToInt32(Console.ReadLine()); //153

            int temp = num;
            int sum = 0;
            int cube;
            int rem;

            while(num != 0)
            {
                rem = num % 10;         //rem= 153%10=3    15%10= 5      1%10=1
                cube = rem * rem * rem;//cube= 3*3*3       5*5*5=125     1*1*1=1
                sum = sum + cube;      //sum = 0+27        27+125=152    152+1=153
                num = num / 10;        //num = 153/10=15   15/10=5       10/10=1
            }
            if(temp == sum)           //153 == 153
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
        }
    }
}
