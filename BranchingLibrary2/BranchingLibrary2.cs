using System;

namespace BranchingLibrary2
{
	public class BranchingL
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <returns></returns>
		public static double Task1(double A, double B)
		{
			if (A > B)
			{
				return (A + B);
			}
			else if (A == B)
			{
				return (A * B);
			}
			else
			{
				return (A - B);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="X"></param>
		/// <param name="Y"></param>
		/// <returns></returns>
		public static int Task2(double X, double Y)
		{
			int Temp;
			if (X > 0 && Y > 0)
			{
				Temp = 1;
			}
			else if (X < 0 && Y < 0)
			{
				Temp = 3;
			}
			else if (X > 0 && Y < 0)
			{
				Temp = 4;
			}
			else if (X < 0 && Y > 0)
			{
				Temp = 2;
			}
			else
			{
				Temp = 0;
			}
			return Temp;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <param name="C"></param>
		/// <returns></returns>
		public static (double min, double average, double max) Task3(double A, double B, double C)
		{
			double max = A;
			double min = B;
			double average = C;

			if (A > B && A > C)
			{
				max = A;
				if (A > B)
                {
					if (B > C)
                    {
						average = B;
						min = C;
					}

					else
                    {
						average = C;
						min = B;
					}
                }
			}

			if (B > C && B > A)
            {
				max = B;
				if (C > A)
                {
					average = C;
					min = A;
				}

				else
                {
					average = A;
					min = C;
				}
            }

			if (C > A && C > B)
            {
				max = C;
				if (A > B)
                {
					average = A;
					min = B;
				}

				else
                {
					average = B;
					min = A;
				}
            }

			return (min, average, max);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <param name="C"></param>
		/// <returns></returns>
		public static (double X1, double X2) Task4(double A, double B, double C)
		{

			double X1;
			double X2;
			double Dis = B * B - 4 * A * C;

			if (Dis == 0)
			{
				X1 = (-B * -B) / (2 * A);
				X2 = X1;
				return (X1, X2);
			}
			else if (Dis < 0)
			{

				return (0, 0);
			}
			else
			{
				X1 = -(B / (2 * A)) + Math.Sqrt(Dis / 4 * A * A);
				X2 = -(B / (2 * A)) - Math.Sqrt(Dis / 4 * A * A);
				return (X1, X2);
			}
		}
	}
}