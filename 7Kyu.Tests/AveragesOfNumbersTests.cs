using NUnit.Framework;
using _7Kyu;

public class SolutionTest
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(string.Join(", ", new double[] { 2, 2, 2, 2 }), string.Join(", ", AveragesOfNumbers.Averages(new int[] { 2, 2, 2, 2, 2 })));
        Assert.AreEqual(string.Join(", ", new double[] { 0, 0, 0, 0 }), string.Join(", ", AveragesOfNumbers.Averages(new int[] { 2, -2, 2, -2, 2 })));
        Assert.AreEqual(string.Join(", ", new double[] { 2, 4, 3, -4.5 }), string.Join(", ", AveragesOfNumbers.Averages(new int[] { 1, 3, 5, 1, -10 })));
        Assert.AreEqual(string.Join(", ", new double[0] ), string.Join(", ", AveragesOfNumbers.Averages(null)));
    }
}