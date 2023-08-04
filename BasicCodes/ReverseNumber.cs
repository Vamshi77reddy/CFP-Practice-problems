using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodes
{
    internal class ReverseNumber
    {
        public void revserse()
        {
            Console.WriteLine("Enter a number: - ");
            int a = int.Parse(Console.ReadLine());
            int rev = 0;
            while (a != 0)
            {
                int last = a % 10;
                rev = rev * 10 + last;
                a = a / 10;
            }
            Console.WriteLine(rev);
        }
    }
}
