using NUnit.Framework;
using VariablesLibrary1;

namespace Lesson8_Test
{
    public class VariablesTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(-5, 4, -1)]
        [TestCase(-8, -2, -6)]
        [TestCase(0, -6, -6)]
        [TestCase(3, 5, 20)]
        public void Test1(double A, double B, double expected)
        {
            double actual = Variables.Task1(A, B);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, 0.75, 3)]
        [TestCase(0, 5, 0, 0)]
        [TestCase(-4, 2, -2, 0)]
        [TestCase(3, 4, 0.75, 3)]
        [TestCase(8, -2, -4, 0)]

        public void Test3(double A, double B, double divexpected, double remaiexpected)
        {
            (double divactual, double remaiactual) = Variables.Task3(A, B);

            Assert.AreEqual(divexpected, divactual);
            Assert.AreEqual(remaiexpected, remaiactual);
        }

        [TestCase(4, 3, 8, 1.25)]
        [TestCase(-5, 8, 1, 1.4)]
        [TestCase(-3, -8, 4, -4)]
        [TestCase(7, 7, 7, 0)]

        public void Test4(double A, double B, double C, double expected)
        {
            double actual = Variables.Task4(A, B, C);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 0, 3, 4, 0.125, 4)]
        [TestCase(-4, 4, -4, 4, -0.5, 6)]
        [TestCase(1, 2, 3, 4, -0.5, 5)]
        [TestCase(7, 3, -8, -2, 0.75, -4.25)]
        public void Test5(double X1, double X2, double Y1, double Y2, double Aexpected, double Bexpected)
        {
            (double Aactual, double Bactual) = Variables.Task5(X1, Y1, X2, Y2);

            Assert.AreEqual(Aexpected, Aactual);
            Assert.AreEqual(Bexpected, Bactual);
        }
    }
}