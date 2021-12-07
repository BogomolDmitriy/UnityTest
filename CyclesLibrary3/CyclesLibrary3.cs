using System;

namespace LibraryLesson4
{
    public class Les4
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int Task1(int A, int B)
        {
            int degree = A;
            for (int i = 2; i <= B; i++)
            {
                degree = degree * A;
            }

            return degree;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] Task2(int A)
        {
            int box = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % A == 0)
                {
                    box++;
                }
            }

            int temp = 0;
            int[] arr = new int[box];
            for (int i = 1; i <= 1000; i++)
            {
                if (i % A == 0)
                {
                    arr[temp] = i;
                    temp++;
                }
            }

            return arr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static double Task3(double A)
        {
            double count = 0;

            for (double i = 1; i <= A; i++)
            {
                if (i * i < A)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static double Task4(double A)
        {
            double divider = 0;

            for (double i = 1; i < (A - 1); i++)
            {
                if (A % i == 0)
                {
                    divider = i;
                }
            }
            return divider;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static double Task5(double A, double B)
        {
            double amount = 0;
            double i = 0;

            if (A > B)
            {
                Console.WriteLine($"{A}>{B} Error");
            }
            else
            {
                for (i = A; i <= B; i++)
                {
                    if (i % 7 == 0)
                    {
                        amount = amount + i;
                    }
                }
            }
            return amount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static double Task6(double N)
        {
            double n1 = 1;
            double n2 = 1;
            double n3 = 0;

            for (int i = 1; i <= (N - 2); i++)
            {
                n3 = n2 + n1;
                n1 = n2;
                n2 = n3;
            }
            return n3;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static double Task7(double A, double B)
        {
            while (A != 0 && B != 0)
            {
                if (A > B)
                {
                    A = A % B;
                }
                else
                {
                    B = B % A;
                }
            }
            return A + B;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static double Task9(double N)
        {
            double amount = 0;

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    amount = amount + 1;
                }
            }

            return amount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] Task10(int A)
        {
            int[] arr = new int[A.ToString().Length];
            int box = 0;
            while (A != 0)
            {
                int number = A % 10;
                arr[box] = number;
                box++;
                A /= 10;
            }

            return arr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int[] Task11(int N)
        {
            int temp = 0;
            int number = 0;
            int even = 0;
            int odd = 0;
            int count = 0;
            int[] arr = new int[N];

            for (int i = 1; i <= N; i++)
            {
                number = i;
                while (number != 0)
                {
                    temp = number % 10;
                    if ((temp % 2) == 0)
                    {
                        even = even + temp;
                    }

                    else
                    {
                        odd = odd + temp;
                    }

                    number = number / 10;
                }

                if (even > odd)
                {
                    arr[i - 1] = i;
                    count++;
                }

                else
                {
                    arr[i - 1] = 0;
                }

                temp = 0;
                even = 0;
                odd = 0;
                number = 0;
            }

            int[] output = new int[count];
            for (int i = 0; i <= N - 1; i++)
            {
                if (arr[i] != 0)
                {
                    output[temp] = arr[i];
                    temp++;
                }
            }

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static string Task12(int A, int B)
        {
            int Control = 0;

            while (A != 0)
            {
                int tempA = A % 10;
                while (B != 0)
                {
                    int tempB = B % 10;
                    if (tempB == tempA)
                    {
                        Control = Control + 1;
                    }
                    B = B / 10;
                }

                A = A / 10;
            }
            if (Control > 0)
            {
                return "Yes";
            }

            else
            {
                return "No";
            }
        }
    }
}