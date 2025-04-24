using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        int[] expected = Array.Empty<int>();

        // Act
        int[] actual = Duplicates.RemoveDuplicates(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 7, 6 };
        int[] expected = new int[] { 1, 2, 3, 7, 6 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 2, -5, -5 };
        int[] expected = new int[] { 1, 2, 3, -5 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {

        // Arrange
        int[] input = new int[] { 6, 6, 6, 6, 6, 6 };
        int[] expected = new int[] { 6 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
