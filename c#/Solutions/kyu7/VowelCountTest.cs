using NUnit.Framework;

namespace Codewars.kyu7
{
    internal class VowelCountTest
    {
        [Test]
        public void TestCase1()
        {
            var errorMsg = "Wrong answer!";
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), errorMsg);
            Assert.AreEqual(1, VowelCount.GetVowelCount("a"), errorMsg);
            Assert.AreEqual(0, VowelCount.GetVowelCount("brc"), errorMsg);
        }
    }
}
