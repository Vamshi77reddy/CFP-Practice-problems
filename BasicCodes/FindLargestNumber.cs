﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodes
{
    internal class FindLargestNumber
    {
        public void findLargestNumber()
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is a largest number ");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is a largest number");
            }
            else
            {
                Console.WriteLine(c + "is a largest number");
            }
        }
    }
}
