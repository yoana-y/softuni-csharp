using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        int[] input = Array.Empty<int>();
        int expected = 0;

        int actual = Majority.IsEvenOrOddMajority(input);

        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual, Is.Zero);

    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        int[] input = new[] { 0, 0, 0, 0 };
        int expected = 0;

        int actual = Majority.IsEvenOrOddMajority(input);

        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual, Is.Zero);

    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        int[] input = new[] { 1, 3, 5, 2, 4, 6 };
        int expected = 0;

        int actual = Majority.IsEvenOrOddMajority(input);

        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual, Is.Zero);
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        int[] input = new[] { 1, 3, 2, 4, 6 };
        int expected = 1;

        int actual = Majority.IsEvenOrOddMajority(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        int[] input = new[] { 1, 3, 5, 4, 6 };
        int expected = -1;

        int actual = Majority.IsEvenOrOddMajority(input);

        Assert.That(actual, Is.EqualTo(expected));

    }
}
