using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodes
{
    internal class VowelorConsonent
    {
        public void Checkvowel()
        {
            Console.WriteLine("Enter a character to check");
            string a = Console.ReadLine();
            if (a == "a" || a == "e" || a == "i" || a == "o" || a == "u" || a == "A" || a == "E" || a == "I" || a == "O" || a == "U")
            {
                Console.WriteLine("its a vowel");
            }
            else
            {
                Console.WriteLine("not vowel");
            }
        }
    }
}
