using NUnit.Framework;
using System;
using _7Kyu;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
    {
        Assert.IsTrue(IsThisATriangle.IsTriangle(5, 7, 10));
    }
}