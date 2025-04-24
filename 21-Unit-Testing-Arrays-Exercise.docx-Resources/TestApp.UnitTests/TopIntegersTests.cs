using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{


    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        int[] input = Array.Empty<int>();
        string expected = string.Empty;

        TopIntegers classInstance = new TopIntegers(); 
        string actual = classInstance.FindTopIntegers(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        int[] input = new int[] { 6, 3, 2 };
        string expected = "6 3 2";

        TopIntegers classInstance = new TopIntegers();
        string actual = classInstance.FindTopIntegers(input);

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        int[] input = new int[] { 6 };
        string expected = "6";

        TopIntegers classInstance = new TopIntegers();
        string actual = classInstance.FindTopIntegers(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        int[] input = new int[] { 2, 42, 12, 31, 6, 15 };
        string expected = "42 31 15";

        TopIntegers classInstance = new TopIntegers();
        string actual = classInstance.FindTopIntegers(input);

        Assert.AreEqual(expected, actual);
    }
}

