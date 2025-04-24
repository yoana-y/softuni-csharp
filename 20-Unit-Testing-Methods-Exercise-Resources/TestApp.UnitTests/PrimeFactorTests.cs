using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long primeNumber = 7;
        long expected = 7;

        long actual = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long primeNumber = 1914;
        long expected = 29;

        long actual = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        Assert.AreEqual(expected, actual);
    }
}
