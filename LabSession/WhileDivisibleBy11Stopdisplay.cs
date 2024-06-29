using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class WhileDivisibleBy11Stopdisplay
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 25)
            {
                if(i% 11 == 0)
                {
                    break;
                   
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
