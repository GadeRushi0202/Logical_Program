﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    internal class prime1to50
    {
        static void Main(string[] args)
        {
            int num = 100;

            for (num = 1; num<=50;num++)
            {
                int count = 0;
                for (int i = 1; i <= num; i++)
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
