using System;
using NUnit.Framework;
using _7Kyu;

[TestFixture]
public static class DateDaysTests
{
    private static void testing(string actual, string expected)
    {
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public static void test1()
    {
        testing(DateDays.DateNbDays(4281, 5087, 2), "2024-07-03");
        testing(DateDays.DateNbDays(4620, 5188, 2), "2021-09-19");
        testing(DateDays.DateNbDays(9999, 11427, 6), "2018-03-13");
        testing(DateDays.DateNbDays(3525, 4822, 3), "2026-04-18");
        testing(DateDays.DateNbDays(5923, 6465, 6), "2017-06-10");
        testing(DateDays.DateNbDays(4254, 4761, 8), "2017-05-22");
        testing(DateDays.DateNbDays(1244, 2566, 4), "2033-11-04");
        testing(DateDays.DateNbDays(6328, 7517, 5), "2019-05-25");
        testing(DateDays.DateNbDays(2920, 3834, 2), "2029-06-03");
        testing(DateDays.DateNbDays(7792, 8987, 4), "2019-07-09");
    }
}