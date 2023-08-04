using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodes
{
    internal class SwapNumbers
    {
        public void swap()
        {
            Console.WriteLine("Enter first number:-");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:- ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("before swapping :- ");
            Console.WriteLine("a= " + a + " b = " + b);

            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine(" After swapping :- ");
            Console.WriteLine("a= " + a + " b = " + b);


        }
    }
}
