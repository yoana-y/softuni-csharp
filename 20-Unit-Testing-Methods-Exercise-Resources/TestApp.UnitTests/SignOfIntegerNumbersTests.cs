using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [Test]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage()
    {
        string input = "asd";
        string expected = "The input is not an integer!";

        string actual = SignOfIntegerNumbers.CheckSign(input);

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        string input = "0";
        string expected = $"The number {input} is zero.";

        string actual = SignOfIntegerNumbers.CheckSign(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {

        string input = "-5";
        string expected = $"The number {input} is negative.";

        string actual = SignOfIntegerNumbers.CheckSign(input);

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        string input = "5";
        string expected = $"The number {input} is positive.";

        string actual = SignOfIntegerNumbers.CheckSign(input);

        Assert.AreEqual(expected, actual);

    }
}
