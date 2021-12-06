using System;

namespace VariablesLibrary1
{
    public class Variables
    {
        /// <summary>
        /// Solution (5*A+B^2)/(B-A)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>The solution must not be zero.</returns>
        public static double Task1(double A, double B)
        {
            if (A - B == 0)
            {
                throw new ArgumentException("Cannot using zero vlues.");
            }
            return ((5 * A + B * B) / (B - A));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public static void Task2(ref string A, ref string B)
        {
            string temp = A;
            A = B;
            B = temp;
        }

        public static (double division, double remainder) Task3(double A, double B)
        {
            if (B == 0)
            {
                throw new ArgumentException("Cannot using zero vlues.");
            }

            return (A / B, A % B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public static double Task4(double A, double B, double C)
        {
            if (C - B == 0 && A == 0)
            {
                throw new ArgumentException("Cannot using zero vlues.");
            }
            return (C - B) / A;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="X1"></param>
        /// <param name="Y1"></param>
        /// <param name="X2"></param>
        /// <param name="Y2"></param>
        /// <returns></returns>
        public static (double A, double B) Task5(double X1, double Y1, double X2, double Y2)
        {
            if (X1 == X2)
            {
                throw new ArgumentException("Cannot using zero vlues.");
            }

            double A = (Y2 - Y1) / (X1 - X2) / 2;
            return ((Y2 - Y1) / (X1 - X2) / 2, Y2 - A * X2);

        }
    }
}
