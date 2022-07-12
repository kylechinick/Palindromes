using System;

namespace Palindromes.Models
{
  public class Palindrome
  {
    string _userWord;

    public Palindrome(string userWord)
    {
      _userWord = userWord;
    }

    public bool PalindromeChecker()
    {
      char[] letterArray = _userWord.ToCharArray();
      char[] reversedArray = _userWord.ToCharArray();
      Array.Reverse(reversedArray);
      for (int i = 0; i < letterArray.Length; i++)
      {
        if (Char.ToLower(letterArray[i]) != Char.ToLower(reversedArray[i]))
        {
          return false;
        }
      }
      return true;
    }
  }
}