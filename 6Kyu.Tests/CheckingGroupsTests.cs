using NUnit.Framework;
using _6kyu;

[TestFixture]
public class GroupsTests
{
    [TestCase("()", true)]
    [TestCase("({", false)]
    [TestCase("[{()}]", true)]
    [TestCase("[[]()]", true)]
    [TestCase("{(})", false)]
    [TestCase("({}[()})", false)]
    public void Tests(string input, bool expected)
    {
        Assert.AreEqual(expected, CheckingGroups.Check(input));
    }
}