using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        List<int> numbers = new();

        (List<int> evens, List<int> odds) actual = ListSplitter.SplitEvenAndOdd(numbers);

        Assert.That(actual.evens, Is.Empty);
        Assert.That(actual.odds, Is.Empty);

    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        List<int> numbers = new() { 2, 4, 6, 8 };

        (List<int> evens, List<int> odds) actual = ListSplitter.SplitEvenAndOdd(numbers);

        CollectionAssert.AreEqual(numbers, actual.evens);
        Assert.That(actual.odds, Is.Empty);


    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        List<int> numbers = new() { 1, 3, 5, 7 };

        (List<int> evens, List<int> odds) actual = ListSplitter.SplitEvenAndOdd(numbers);

        CollectionAssert.AreEqual(numbers, actual.odds);
        Assert.That(actual.evens, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7 };
        List<int> evenNums = new() { 2, 4, 6 };
        List<int> oddNums = new() { 1, 3, 5, 7 };

        (List<int> evens, List<int> odds) actual = ListSplitter.SplitEvenAndOdd(numbers);

        CollectionAssert.AreEqual(evenNums, actual.evens);
        CollectionAssert.AreEqual(oddNums, actual.odds);

    }
}
