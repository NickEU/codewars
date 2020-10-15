using NUnit.Framework;

namespace Codewars.kyu5
{
    internal class MovingZeroesToTheEndTest
    {
        [Test]
        public void Test1()
        {
            var expected = new[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0};
            var actual = MovingZeroesToTheEnd
                .MoveZeroes(new[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1});
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            var expected = new[] {0, 0, 0, 0};
            var actual = MovingZeroesToTheEnd
                .MoveZeroes(new[] {0, 0, 0, 0});
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            var expected = new[] {1, 2, 1, 1};
            var actual = MovingZeroesToTheEnd
                .MoveZeroes(new[] {1, 2, 1, 1});
            Assert.AreEqual(expected, actual);
        }
    }
}