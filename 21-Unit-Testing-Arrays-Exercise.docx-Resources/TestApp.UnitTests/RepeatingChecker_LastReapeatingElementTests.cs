using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        int expected = -1;

        // Act
        int actual = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(actual, Is.Negative.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { 1 };
        int expected = -1;

        // Act
        int actual = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(actual, Is.Negative.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { 1000, -30, 500 };
        int expected = -1;

        // Act
        int actual = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(actual, Is.Negative);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] input = new int[] { -1, -1 };
        int expected = -1;

        // Act
        int actual = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(actual, Is.Negative.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] input = new int[] { 6, 5, 6, 5 };
        int expected = 5;

        // Act
        int actual = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(actual, Is.Positive.And.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] input = new int[] { 5, 6, -7, 8, 6, -7, 8 };
        int expected = 8;

        // Act
        int actual = RepeatingChecker.FindLastRepeatingElement(input);

        // Assert
        Assert.That(actual, Is.Positive.And.EqualTo(expected));
    }
}
