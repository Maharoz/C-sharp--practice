﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i =1; i <= 10; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            for(var i = 10; i>1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
