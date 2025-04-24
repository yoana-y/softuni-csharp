using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        string input = "";
        string expected = "Empty string";

        string actual = MiddleCharacters.GetMiddleChars(input);

        Assert.AreEqual(expected, actual);
    
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {

        string input = " ";
        string expected = "Empty string";

        string actual = MiddleCharacters.GetMiddleChars(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {

        string input = "L";
        string expected = "L";

        string actual = MiddleCharacters.GetMiddleChars(input);

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        string input = "MEOW";
        string expected = "EO";

        string actual = MiddleCharacters.GetMiddleChars(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        string input = "UwUuw";
        string expected = "U";

        string actual = MiddleCharacters.GetMiddleChars(input);

        Assert.AreEqual(expected, actual);
    }
}
