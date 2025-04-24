using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        List<int> irstList = new();
        List<int> secondList = new() { 1, 2, 3 };


        List<int> expected = new();

        List<int> actual = SameValues.FindSameValues(irstList, secondList);

        Assert.AreEqual(expected, actual);
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        List<int> irstList = new() { 1, 2, 3 };
        List<int> secondList = new();


        List<int> expected = new();

        List<int> actual = SameValues.FindSameValues(irstList, secondList);

        Assert.AreEqual(expected, actual);
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        List<int> irstList = new() { 1, 2, 3 };
        List<int> secondList = new() { 4, 5, 6 };


        List<int> expected = new();

        List<int> actual = SameValues.FindSameValues(irstList, secondList);

        Assert.AreEqual(expected, actual);
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        List<int> irstList = new() { 1, 2, 3, 4, 5 };
        List<int> secondList = new() { 2, 8, 3, 10, 55};


        List<int> expected = new() { 2, 3 };

        List<int> actual = SameValues.FindSameValues(irstList, secondList);

        Assert.AreEqual(expected, actual);
        
    }
}
