using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> numbers = new() { };
        List<int> expected = new() { };

        List<int> actual = pi.FindPalindromes(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> numbers = new() { 23, 4546, 90, 7778};
        List<int> expected = new() { };

        List<int> actual = pi.FindPalindromes(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> numbers = new() { 1, 2, 3, 4, 5 };
        List<int> expected = new() { 1, 2, 3, 4, 5 };

        List<int> actual = pi.FindPalindromes(numbers);

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> numbers = new() { 101, 202, 303, 646 };
        List<int> expected = new() { 101, 202, 303, 646 };

        List<int> actual = pi.FindPalindromes(numbers);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> numbers = new() { 101, 245, 303, 646, 576 };
        List<int> expected = new() { 101, 303, 646 };

        List<int> actual = pi.FindPalindromes(numbers);

        Assert.AreEqual(expected, actual);

    }
}
