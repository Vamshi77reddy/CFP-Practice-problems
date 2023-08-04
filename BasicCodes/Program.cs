using System;

namespace BasicCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p1 = new Program();
            //  p1.Prime();
            //  Palindrome p2 = new Palindrome();
            // p2.PalindromeMethod();
            // LeapYear p3 = new LeapYear();
            //p3.leap();
            //  NaturalNumbers p4 = new NaturalNumbers();
            //p4.Numbers();
            //NumbersUsingWhile p5= new NumbersUsingWhile();
            //p5.WhileLoop();
            // EvenorOdd p6 = new EvenorOdd();
            // p6.evenorodd();
            // ReverseNumber p7= new ReverseNumber();
            // p7.revserse();
            //SwapNumbers p8 = new SwapNumbers();
            //p8.swap();
            //VowelorConsonent p9 = new VowelorConsonent();
            //p9.Checkvowel();
            FindLargestNumber p10 = new FindLargestNumber();
            p10.findLargestNumber();
        }

        public void Prime()
        {
            Boolean flag = true;
            Console.WriteLine("Enter a number to check weather it is prime or not:- ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 2; i <= a / 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("is not a prime number");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("it is prime");
            }
        }

    }
}
