using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodes
{
    internal class EvenorOdd
    {
        public void evenorodd()
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("odd");
        }
    }
}
