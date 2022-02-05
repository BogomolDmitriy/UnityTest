using System;

namespace LibraryLesson5
{
	public class Lesson5
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="range"></param>
		/// <returns></returns>
		public static int[] Random(int range)
		{
			if (range <= 0)
			{
				throw new ArgumentException("Negative number of array cells?");
			}
			int[] arr = new int[range];
			Random random = new Random();
			for (int i = 0; i < range; i++)
			{
				arr[i] = random.Next(0, 100);
			}

			return (arr);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static int Task1(int[] arr)
		{

			int min = arr[0];

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
				}
			}

			return min;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static int Task2(int[] arr)
		{
			int max = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
			}

			return max;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static int Task3(int[] arr)
		{
			int min = arr[0];
			int index = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
					index = i;
				}
			}

			return index;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static int Task4(int[] arr)
		{
			int max = arr[0];
			int index = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
					index = i;
				}
			}

			return index;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static int Task5(int[] arr)
		{
			int sum = 0;
			for (int i = 0; i < arr.Length; i = i + 2)
			{
				sum = sum + arr[i];
			}

			return (sum);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static int[] Task6(int[] arr)
		{
			int[] reverse = new int[arr.Length];

			for (int i = arr.Length - 1; i >= 0; i--)
			{
				reverse[i] = arr[i];
			}

			return reverse;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static int Task7(int[] arr)
		{
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if ((arr[i] % 2) != 0)
				{
					sum++;
				}
			}

			return sum;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		public static int[] Task8(int[] arr)
		{
			int odd = arr.Length % 2;
			for (int i = 0; i < arr.Length / 2; i++)
			{
				Swap(ref arr[i], ref arr[arr.Length / 2 + odd + i]);
			}

			return arr;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}

		public static int[] Task9(int[] arr)
		{
			if (arr.Length <= 1)
            {
				return arr;
			}

			else
            {
				for (int i = 0; i < arr.Length - 1; i++)
				{
					for (int j = i + 1; j < arr.Length; j++)
					{
						if (arr[i] > arr[j])
						{
							Swap(ref arr[i], ref arr[j]);
						}
					}
				}

				return arr;
			}
		}

		public static int [] sortingMachiv (int[] arr)
        {
			if (arr.Length<=1)
            {
				return arr;
			}

			else
            {
				int counter;
				do
                {
					counter = 0;
					for (int i = 1; i < arr.Length; i++)
					{
						if (arr[i - 1] > arr[i])
						{
							Swap(ref arr[i - 1], ref arr[i]);
							counter++;
						}
					}
				}
				while (counter > 0);
				return arr;
			}

		}
	}
}