using NUnit.Framework;
using LibraryLesson4;

namespace RamificationTest
{
    public class UnitTest
    {
        [TestCase(5, 5, 3125)]
        [TestCase(3, 1, 3)]
        [TestCase(1, 8, 1)]
        [TestCase(2, 4, 16)]
        public void Test1(int A, int B, int expected)
        {
            int actual = Les4.Task1(A, B);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(85, new[] {85, 170, 255, 340, 425, 510, 595, 680, 765, 850, 935})]

        public void Test2(int A, int [] expected)
        {
            int [] actual = Les4.Task2(A);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(14, 3)]
        [TestCase(85, 9)]
        [TestCase(857, 29)]
        public void Test3(double A, double expected)
        {
            double actual = Les4.Task3(A);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 4)]
        [TestCase(95, 19)]
        [TestCase(6, 3)]
        [TestCase(48, 24)]
        [TestCase(1586, 793)]

        public void Test4(double A, double expected)
        {
            double actual = Les4.Task4(A);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 76, 378)]
        [TestCase(1, 24, 42)]
        [TestCase(895, 1250, 54621)]

        public void Test5(double A, double B, double expected)
        {
            double actual = Les4.Task5(A, B);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5)]
        [TestCase(15, 610)]
        [TestCase(8, 21)]
        [TestCase(1, 0)]
        [TestCase(3, 2)]

        public void Test6(double A, double expected)
        {
            double actual = Les4.Task6(A);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 29, 1)]
        [TestCase(8, 16, 8)]
        [TestCase(86, 12, 2)]

        public void Test7(double A, double B, double expected)
        {
            double actual = Les4.Task7(A, B);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 12)]
        [TestCase(2, 1)]
        [TestCase(48, 24)]
        [TestCase(7, 3)]
        [TestCase(1, 0)]

        public void Test9(double A, double expected)
        {
            double actual = Les4.Task9(A);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(85, new[] { 5, 8 })]
        [TestCase(289, new[] { 9, 8, 2 })]
        [TestCase(5, new[] { 5 })]
        [TestCase(12345, new[] { 5, 4, 3, 2, 1 })]

        public void Test10(int A, int [] expected)
        {
            int [] actual = Les4.Task10(A);

            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(15, new[] { 2, 4, 6, 8, 12, 14 })]
        [TestCase(2, new[] { 2 })]
        [TestCase(8, new[] { 2, 4, 6, 8 })]

        public void Test11(int A, int [] expected)
        {
            int [] actual = Les4.Task11(A);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, 5, "Yes")]
        [TestCase(2, 2, "Yes")]
        [TestCase(258, 491, "No")]
        [TestCase(8, 1, "No")]

        public void Test12(int A, int B, string expected)
        {
            string actual = Les4.Task12(A, B);

            Assert.AreEqual(expected, actual);
        }
    }

}