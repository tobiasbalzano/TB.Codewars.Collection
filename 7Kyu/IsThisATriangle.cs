using System;

namespace _7Kyu
{
    //Description:
    ////Implement a method that accepts 3 integer values a, b, c.The method should return true if a triangle can be built with the sides of given length and false in any other case.

    //(In this case, all triangles must have surface greater than 0 to be accepted).

    public static class IsThisATriangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            return false;

            //Best solution: 
            //return (a + b > c && a + c > b && b + c > a && a * b * c > 0);
        }
    }
}
