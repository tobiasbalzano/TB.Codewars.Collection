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
            /// TODO: Gör om, gör rätt.... jisses
            List<char> openingChars = new List<char> { '(', '[', '{' };
            List<char> closingChars = new List<char> { ')', ']', '}' };
            List<char> openedOrder = new List<char>();
            List<char> closedOrder = new List<char>();
            foreach (char c in input)
            {
                if (c == openingChars[0] || c == openingChars[1] || c == openingChars[2])
                    openedOrder.Add(c);
                else if (c == closingChars[0] || c == closingChars[1] || c == closingChars[2])
                    closedOrder.Add(c);
            }
            while (openedOrder.Count > 0)
            {
                if (openingChars.IndexOf(openedOrder[openedOrder.Count - 1]) != closingChars.IndexOf(closedOrder[0]))
                    return false;
                openedOrder.RemoveAt(openedOrder.Count - 1);
                closedOrder.RemoveAt(0);
            }

            return false;
        }
    }
}
