using System;
using System.Collections.Generic;
using Palindromes.Models;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a single word for Palindrom-ification: ");
      string userWord = Console.ReadLine();
      Palindrome newPalindrome = new Palindrome(userWord);
      Console.WriteLine(newPalindrome.PalindromeChecker());
    }
  }
}