using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        List<double> grades = new() { 1.2, 1.5, 1.6 };
        string expected = "Incorrect grades";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        List<double> grades = new() { 6.6, 6.7, 7.2 };
        string expected = "Incorrect grades";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {

        List<double> grades = new() { 2, 2, 2 };
        string expected = "Fail";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        List<double> grades = new() { 3, 2, 4 };
        string expected = "Poor";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        List<double> grades = new() { 3.50, 3.50, 4.50 };
        string expected = "Good";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        List<double> grades = new() { 5, 4.50, 5 };
        string expected = "Very good";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {

        List<double> grades = new() { 5, 5.50, 6 };
        string expected = "Excellent";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.AreEqual(expected, actual);

    }
}
