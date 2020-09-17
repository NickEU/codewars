using NUnit.Framework;

namespace Codewars
{
    [TestFixture]
    public class JadenCaseTest
    {
        private const string ErrorMsg = "Strings didn't match.";

        [Test]
        public void FixedTest1()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                JadenCase.ToJadenCase("How can mirrors be real if our eyes aren't real"),
                ErrorMsg);
        }

        [Test]
        public void FixedTest2()
        {
            Assert.AreEqual("People Tell Me To Smile I Tell Them The Lack Of Emotion In My Face Doesn't Mean I'm Unhappy",
                JadenCase.ToJadenCase("People tell me to smile I tell them the lack of emotion in my face doesn't mean I'm unhappy"),
                ErrorMsg);
        }

        public void FixedTest3()
        {
            Assert.AreEqual("Three Men, Six Options, Don't Choose.",
                JadenCase.ToJadenCase("Three men, six options, don't choose."),
                ErrorMsg);
        }
    }
}
