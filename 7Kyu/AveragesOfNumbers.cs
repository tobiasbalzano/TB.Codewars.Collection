using System.Collections.Generic;

namespace _7Kyu
{
    //Description:
    //    Get the averages of these numbers

    //Write a method, that gets an array of integer-numbers and return an array of the averages of each integer-number and his follower, if there is one.

    //Example:

    //Input:  [ 1, 3, 5, 1, -10]
    //    Output:  [ 2, 4, 3, -4.5]
    //    If the array has 0 or 1 values or is null or None, your method should return an empty array.

    public static class AveragesOfNumbers
    {
        public static double[] Averages(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
                return new double[0];
            List<double> ls = new List<double>();
            for (int i = 0; i + 1 < numbers.Length; i++)
                ls.Add((double)(numbers[i] + numbers[i + 1]) / 2);
            return ls.ToArray();

        }
    }
}
