﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Factorial number: ");
            double factorial = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            for (double i = 1; i <= factorial; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
