using System.Linq;

namespace Codewars.kyu7
{
    internal class HighestAndLowest
    {
        public static string HighAndLow(string str)
        {
            var numbers = str.Split(" ")
                .Select(int.Parse).ToList();
            return $"{numbers.Max()} {numbers.Min()}";
        }
    }
}
