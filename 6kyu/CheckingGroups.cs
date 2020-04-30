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
            ///TODO: 
            ///Rekursiv lista beroende på öppnar eller stänger?
            ///Regex 
            ///Eget objekt med koll på om nästa char öppnar eller stänger?
            List<char> openingChars = new List<char> { '(', '[', '{' };
            List<char> closingChars = new List<char> { ')', ']', '}' };
            var openingDictionary = new Dictionary<int, string>();
            List<GroupingChar> CharOrder = new List<GroupingChar>();
            foreach (char c in input)
            {
                if (openingChars.Contains(c) || closingChars.Contains(c))
                    inputStringToCharList.Add(c);
            }
            for (int i = 0; i < inputStringToCharList.Count; i++)
            {
                GroupingChar gC = new GroupingChar
                {
                    Char = inputStringToCharList[i],
                    ChildChar = openingChars.Contains(inputStringToCharList[i + 1]) ? new List<GroupingChar>() : null
                };
            }

            return false;
        }

        public class GroupingChar
        {
            public char Char { get; set; }
            public List<GroupingChar> ChildChar { get; set; }
        }
    }
}
