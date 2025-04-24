using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        int[] input = Array.Empty<int>();
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        int[] input = new int[] { 1 };
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        int[] input = new int[] { 1, 23, 56 };
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        int[] input = new int[] { -1, -1 };
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        int[] input = new int[] { 6, 5, 6, 5 };
        int expected = 6;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        int[] input = new int[] { 1, 2, 3, 2, 4, 5, 5, 6 };
        int expected = 2;

        int actual = RepeatingChecker.FindFirstRepeatingElement(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
