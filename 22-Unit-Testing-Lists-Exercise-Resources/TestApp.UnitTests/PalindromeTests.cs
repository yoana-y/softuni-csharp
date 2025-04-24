using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "ava", "mlelm" };

        // Act

        bool actual = Palindrome.IsPalindrome(input);

        // Assert

        Assert.That(actual, Is.True);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        bool actual = Palindrome.IsPalindrome(words);

        // Assert

        Assert.That(actual, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "mlelm" };

        // Act

        bool actual = Palindrome.IsPalindrome(input);

        // Assert

        Assert.That(actual, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> input = new() { "avai", "mlem", "meow" };

        // Act

        bool actual = Palindrome.IsPalindrome(input);

        // Assert

        Assert.That(actual, Is.False);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "CaC", "TaT", "PoP" };

        // Act

        bool actual = Palindrome.IsPalindrome(input);

        // Assert

        Assert.That(actual, Is.True);
    }
}
