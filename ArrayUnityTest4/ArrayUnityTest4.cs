using NUnit.Framework;
using LibraryLesson5;

namespace Lesson5array
{
    public class ArrayTest
    {
        [TestCase(new[] { 1, 2, 9 }, 1)]
        [TestCase(new[] { 2 }, 2)]
        [TestCase(new[] { 1, 1, 1 }, 1)]
        [TestCase(new[] { -50, -9, 40 }, -50)]
        [TestCase(new[] { 0, 9, 71 }, 0)]
        public void Task1(int[] arr, int expected)
        {
            double actual = Lesson5.Task1(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 9 }, 9)]
        [TestCase(new[] { 2 }, 2)]
        [TestCase(new[] { 1, 1, 1 }, 1)]
        [TestCase(new[] { -50, -9, 40 }, 40)]
        [TestCase(new[] { 0, 9, 71 }, 71)]
        public void Task2(int[] arr, int expected)
        {
            double actual = Lesson5.Task2(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 9 }, 0)]
        [TestCase(new[] { 2 }, 0)]
        [TestCase(new[] { 1, 1, 1 }, 0)]
        [TestCase(new[] { -1, -9, 40 }, 1)]
        [TestCase(new[] { 0, 9, -71 }, 2)]
        public void Task3(int[] arr, int expected)
        {
            double actual = Lesson5.Task3(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 9 }, 2)]
        [TestCase(new[] { 2 }, 0)]
        [TestCase(new[] { 1, 1, 1 }, 0)]
        [TestCase(new[] { -1, -9, 40 }, 2)]
        [TestCase(new[] { 0, 9, -71 }, 1)]
        public void Task4(int[] arr, int expected)
        {
            double actual = Lesson5.Task4(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 9 }, 10)]
        [TestCase(new[] { 2 }, 2)]
        [TestCase(new[] { 1, 1, 1 }, 2)]
        [TestCase(new[] { -1, -9, 40, 8, 0 }, 39)]
        [TestCase(new[] { 0, 9, -71 }, -71)]
        public void Task5(int[] arr, int expected)
        {
            double actual = Lesson5.Task5(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 9 }, 2)]
        [TestCase(new[] { 2 }, 0)]
        [TestCase(new[] { 1, 1, 1 }, 3)]
        [TestCase(new[] { -1, -9, 40, 8, 0 }, 2)]
        [TestCase(new[] { 0, 9, -71 }, 2)]

        public void Task7(int[] arr, int expected)
        {
            double actual = Lesson5.Task7(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 83, 96, 84, 7, 29, 75 }, new[] { 7, 29, 75, 83, 96, 84 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 4, 5, 3, 1, 2 })]
        [TestCase(new[] { 1, 2, 3, 4, }, new[] { 3, 4, 1, 2 })]

        public void Task8(int[] arr, int[] expected)
        {
            int[] actual = Lesson5.Task8(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 83, 96, 84, 7, 29, 75 }, new[] { 7, 29, 75, 83, 84, 96 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 1, 2, 0, 4, }, new[] { 0, 1, 2, 4 })]

        public void Task9(int[] arr, int[] expected)
        {
            int[] actual = Lesson5.Task9(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}