using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] inputWe = { 'a', '1', 'b', '2', 'c' };
        char[] expected = { 'a', 'b', 'c' };

        char[] actual = Fake.RemoveStringNumbers(inputWe);

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] inputWe = { 'a', 'b', 'c' };
        char[] expected = { 'a', 'b', 'c' };

        char[] actual = Fake.RemoveStringNumbers(inputWe);

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] inputWe = Array.Empty<char>();
        char[] expected = Array.Empty<char>();

        char[] actual = Fake.RemoveStringNumbers(inputWe);

        Assert.That(actual, Is.Empty);
        CollectionAssert.AreEqual(expected, actual);
    }
}
