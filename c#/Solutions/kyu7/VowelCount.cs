using System.Linq;

namespace Codewars.kyu7
{
    internal class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            return str.Count(c => "aoeui".Contains((char) c));
        }
    }
}
