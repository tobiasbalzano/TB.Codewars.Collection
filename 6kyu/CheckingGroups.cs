using System.Collections.Generic;

namespace _6kyu
{
    //Description: https://www.codewars.com/kata/checking-groups/train/csharp
    //In English and programming, groups can be made using symbols such as "()" and "{}" that change meaning.However, these groups must be closed in the correct order to maintain correct syntax.

    //Your job in this kata will be to make a program that checks a string for correct grouping. For instance, the following groups are done correctly:

    //({})
    //[[]()]
    //[{()}]
    //The next are done incorrectly

    //{(})
    //([]
    //[])
    //A correct string cannot close groups in the wrong order, open a group but fail to close it, or close a group before it is opened.

    //Your function will take an input string that may contain any of the symbols "()" "{}" or "[]" to create groups.

    //It should return True if the string is empty or otherwise grouped correctly, or False if it is grouped incorrectly.

    public static class CheckingGroups
    {
        public static bool Check(string input)
        {
            char[] openingChars = { '(', '[', '{' };
            char[] closingChars = { ')', ']', '}' };
            List<char> openedOrder = new List<char>();
            foreach(char c in input)
            {
                if (c == openingChars[0] || c == openingChars[1] || c == openingChars[2])
                    openedOrder.Add(c);
            }

            return false;
        }
    }
}
