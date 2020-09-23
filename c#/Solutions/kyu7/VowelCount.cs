using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            return str.Count(c => "aoeui".Contains((char) c));
        }
    }
}
