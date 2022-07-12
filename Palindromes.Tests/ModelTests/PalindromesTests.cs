using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.Test
{
  [TestClass]
  public class PalindromeTest
  {
    [TestMethod]
    public void PalindromeChecker_ChecksIfPalindrome_False()
    {
      Palindrome newPalindrome = new Palindrome("Hello");
      Assert.AreEqual(false, newPalindrome.PalindromeChecker());
    }

    [TestMethod]
    public void PalindromeChecker_ChecksIfPalindrome_True()
    {
      Palindrome newPalindrome = new Palindrome("racecar");
      Assert.AreEqual(true, newPalindrome.PalindromeChecker());
    }
  }
}