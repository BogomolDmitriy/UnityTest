using System;

namespace LibraryLesson7
{
    public class LibraryArr
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Y"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public static int[,] Random(int Y, int X)
        {
            if (Y <= 0 || X <= 0)
            {
                throw new ArgumentException("Wrong size of array!");
            }
            int[,] arr = new int[X, Y];
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1000);
                }
            }

            return arr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Task1(int[,] arr)
        {

            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }

            return min;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Task2(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            return max;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (int column, int line) Task3(int[,] arr)
        {
            int line = 0;
            int column = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[column, line])
                    {
                        column = i;
                        line = j;
                    }
                }
            }

            return (column, line);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (int column, int line) Task4(int[,] arr)
        {
            int line = 0;
            int column = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[column, line])
                    {
                        column = i;
                        line = j;
                    }
                }
            }

            return (column, line);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Task5(int[,] arr)
        {
            int more = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int counter = 0;
                    //1
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        if (arr[i, j] > arr[i - 1, j - 1])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //2
                    if (i - 1 >= 0)
                    {
                        if (arr[i, j] > arr[i - 1, j])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //3
                    if (i - 1 >= 0 && j + 1 <= arr.GetLength(1) - 1)
                    {
                        if (arr[i, j] > arr[i - 1, j + 1])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //4
                    if (j - 1 >= 0)
                    {
                        if (arr[i, j] > arr[i, j - 1])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //5
                    if (j + 1 <= arr.GetLength(1) - 1)
                    {
                        if (arr[i, j] > arr[i, j + 1])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //6
                    if (i + 1 <= arr.GetLength(0) - 1 && j - 1 >= 0)
                    {
                        if (arr[i, j] > arr[i + 1, j - 1])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //7
                    if (i + 1 <= arr.GetLength(0) - 1)
                    {
                        if (arr[i, j] > arr[i + 1, j])
                        {
                            counter++;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    //8
                    if (i + 1 <= arr.GetLength(0) - 1 && j + 1 <= arr.GetLength(1) - 1)
                    {
                        if (arr[i, j] > arr[i + 1, j + 1])
                        {
                            counter = counter + 1;
                        }
                    }

                    else
                    {
                        counter++;
                    }

                    if (counter == 8)
                    {
                        more++;
                    }
                }
            }

            return (more);
        }
    }
}