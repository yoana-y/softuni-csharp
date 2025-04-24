using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        List<int> input = new();
        int treshold = 5;

        List<int> actual = ListRemover.RemoveElementsGreaterThan(input, treshold);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        List<int> input = new() { 6, 8, 7};
        int treshold = 5;

        List<int> actual = ListRemover.RemoveElementsGreaterThan(input, treshold);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        List<int> input = new() { 1, 2, 5 };
        int treshold = 5;
        List<int> expected = new() { 1, 2, 5 };

        List<int> actual = ListRemover.RemoveElementsGreaterThan(input, treshold);

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        List<int> input = new() { 1, 2, 5, 6, 7, 8 };
        int treshold = 5;
        List<int> expected = new() { 1, 2, 5 };

        List<int> actual = ListRemover.RemoveElementsGreaterThan(input, treshold);

        CollectionAssert.AreEqual(expected, actual);
    }
}
