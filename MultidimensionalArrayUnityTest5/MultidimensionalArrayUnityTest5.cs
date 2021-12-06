using NUnit.Framework;
using LibraryLesson7;

namespace MultidimensionalArraysTests
{
    public class LibraryLesson7
    {
        [TestCaseSource(nameof(MinAlement))]
        public void Task1(int[,] arr, int expectedResult)
        {
            var actualResult = LibraryArr.Task1(arr);
            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] MinAlement =
        {
            new object[]{
                new int[,]{ { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } },
                (1)
            },
            new object[]{
                new int[,]{ { 4, 5, 6 }, { 3, 2, 3 } },
                (2)
            }
        };

        [TestCaseSource(nameof(MaxAlement))]
        public void Task2(int[,] arr, int expectedResult)
        {
            var actualResult = LibraryArr.Task2(arr);
            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] MaxAlement =
        {
            new object[]{
                new int[,]{ { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } },
                (9)
            },
            new object[]{
                new int[,]{ { 4, 5, 6 }, { 3, 2, 3 } },
                (6)
            }
        };

        [TestCaseSource(nameof(MinICases))]
        public void Task3(int[,] arr, (int, int) expectedResult)
        {
            var actualResult = LibraryArr.Task3(arr);
            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] MinICases =
        {
            new object[]{
                new int[,]{ { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } },
                (0, 2)
            },
            new object[]{
                new int[,]{ { 4, 5, 6 }, { 3, 1, 2 } },
                (1, 1)
            }
        };

        [TestCaseSource(nameof(MaxICases))]
        public void Task4(int[,] arr, (int, int) expectedResult)
        {
            var actualResult = LibraryArr.Task4(arr);
            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] MaxICases =
        {
            new object[]{
                new int[,]{ { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } },
                (2, 2)
            },
            new object[]{
                new int[,]{ { 4, 5, 6 }, { 3, 1, 2 } },
                (0, 2)
            }
        };

        [TestCaseSource(nameof(Most))]
        public void Task5(int[,] arr, int expectedResult)
        {
            var actualResult = LibraryArr.Task5(arr);
            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] Most =
        {
            new object[]{
                new int[,]{ { 3, 2, 6 }, { 4, 5, 1 }, { 7, 8, 9 } },
                (2)
            },
            new object[]{
                new int[,]{ { 4, 5, 6 }, { 3, 1, 2 } },
                (1)
            }
        };

    }
}