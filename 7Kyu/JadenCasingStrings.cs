using System.Collections.Generic;

namespace _7Kyu
{
    public static class JadenCasingStrings
    {
        //Description:

        //Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid(2010) and After Earth(2013). Jaden is also known for some of his philosophy that he    delivers via Twitter.When writing on Twitter, he is known for almost always capitalizing every word.

        //Your task is to convert strings to how they would be written by Jaden Smith.The strings are actual quotes from Jaden Smith, but they are not capitalized in the same  way  he originally typed them.
        //Example:

        //Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
        //Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"


        public static string ToJadenCase(this string phrase)
        {
            List<string> outList = new List<string>();
            foreach (string s in phrase.Split(' '))
            {
                if (s != " ")
                {
                    var str2 = s.Substring(0, 1).ToUpper();
                    outList.Add(str2 + s.Remove(0, 1));
                }
            }
            return string.Join(" ", outList.ToArray());

            //optimal solution:
            //return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }
    }
}
