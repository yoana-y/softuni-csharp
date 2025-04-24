using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        int number = 0;
        int expected = 0;

        int actual = Fibonacci.CalculateFibonacci(number);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int number = 1;
        int expected = 1;

        int actual = Fibonacci.CalculateFibonacci(number);

        Assert.AreEqual(expected, actual);
    }
}