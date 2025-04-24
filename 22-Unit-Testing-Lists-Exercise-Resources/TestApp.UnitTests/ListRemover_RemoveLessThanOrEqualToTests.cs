using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        List<int> input = new();
        int treshold = 5;

        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshold);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        List<int> input = new() { 1, 2, 3, 5 };
        int treshold = 5;

        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshold);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        List<int> input = new() { 6, 7, 8, 9 };
        int treshold = 5;
        List<int> expected = new() { 6, 7, 8, 9 };

        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshold);

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        List<int> input = new() { 6, 7, 8, 9, 1, 2, 3 };
        int treshold = 5;
        List<int> expected = new() { 6, 7, 8, 9 };

        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshold);

        CollectionAssert.AreEqual(expected, actual);
    }
}
