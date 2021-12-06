using NUnit.Framework;
using BranchingLibrary2;

namespace RamificationTest
{
    public class UnitTest
    {
        [TestCase(5, 5, 25)]
        [TestCase(-3, 0, -3)]
        [TestCase(1, 1, 1)]
        [TestCase(6, 8, -2)]
        public void Test1(double A, double B, double expected)
        {
            double actual = BranchingL.Task1(A, B);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-2, 2, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, 0, 0)]
        [TestCase(4, 2, 1)]
        [TestCase(3, -1, 4)]
        [TestCase(-2, -5, 3)]
        public void Test2(int X, int Y, int expected)
        {
            int actual = BranchingL.Task2(X, Y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 3, 5, 3, 4, 5)]
        [TestCase(1, 2, 3, 1, 2, 3)]
        [TestCase(3, 2, 1, 1, 2, 3)]
        [TestCase(110, 80, 258, 80, 110, 258)]
        public void Test3(double A, double B, double C, double maxexpected, double averageexpected, double minexpected)
        {
            (double maxactual, double averageactual, double minactual) = BranchingL.Task3(A, B, C);

            Assert.AreEqual(maxexpected, maxactual);
            Assert.AreEqual(averageexpected, averageactual);
            Assert.AreEqual(minexpected, minactual);
        }


    }

}