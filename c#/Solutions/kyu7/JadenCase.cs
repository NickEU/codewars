using System.Linq;

namespace Codewars.kyu7
{
    internal static class JadenCase
    {
        public static string ToJadenCase(string phrase)
        {
            var titleCased = from word in phrase.Split(" ")
                select word[0].ToString().ToUpper() + word.Substring(1);
            return string.Join(" ", titleCased);
        }
    }
}
