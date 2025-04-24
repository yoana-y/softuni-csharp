using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] input = { 1, 2, 3, 3, 2, 1 };
        int[] expected = { 1, 3, 2 };

        int[] actual = Pattern.SortInPattern(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] input = Array.Empty<int>();
        int[] expected = Array.Empty<int>();

        int[] actual = Pattern.SortInPattern(input);

        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] input = { 1 };
        int[] expected = { 1 };

        int[] actual = Pattern.SortInPattern(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
