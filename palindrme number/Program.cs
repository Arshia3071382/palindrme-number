using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrme_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome number in the range of zero to one thousand:");

            for (int i = 200; i <= 500; i++)
            {
                if (ispalindrome(i))
                {
                    Console.WriteLine(i);

                }


            }
        }
        public static bool ispalindrome(int number)
        {
            int originalNumber = number;
            int reverseNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reverseNumber = (reverseNumber * 10) + remainder;
                number = number / 10;
            }




            return originalNumber == reverseNumber;

        }
    }
}



