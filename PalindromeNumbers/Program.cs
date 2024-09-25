using PalindromeNumbers.Models;

namespace PalindromeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Palindrome.CheckPalindrome(number));
        }
    }
}
