using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions.Arrays
{
    public class ArraysSolutions
    {
        static void MinAndMax(int[] arr)
        {
            long min = Int64.MaxValue, max = Int64.MinValue;

            for (int i = 0; i < arr.Length; ++i)
            {
                long sum = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    sum += i == j ? 0 : arr[j];
                }

                if (sum > max)
                {
                    max = sum;
                }

                if (sum < min)
                {
                    min = sum;
                }
            }

            Console.WriteLine("{0} {1}", min, max);
        }
    }
}
