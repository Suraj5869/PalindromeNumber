using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumbers.Models
{
    internal class Palindrome
    {
        public static string CheckPalindrome(int number)
        {
            int divisor = 10;
            int temp = number;
            int reverseNumber = 0;

            //reverse the number
            while (temp > 0)
            {
                int digit = temp % divisor;
                temp /= divisor;
                reverseNumber = reverseNumber * 10 + digit;
            }

            //Check the reverse number is equal to original number
            if (reverseNumber == number)
            {
                return $"The entered number {number} is a Palindrome.";
            }

            return $"The entered number {number} is not a Palindrome.";
        }
    }
}
