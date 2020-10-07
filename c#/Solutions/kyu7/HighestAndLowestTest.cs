using NUnit.Framework;

namespace Codewars.kyu7
{
    internal class HighestAndLowestTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9",
                HighestAndLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
            Assert.AreEqual("3 3",
                HighestAndLowest.HighAndLow("3 3 3"));
            Assert.AreEqual("-7 -22",
                HighestAndLowest.HighAndLow("-7 -9 -22"));
        }
    }
}
