using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Interview_Preparation_Kit
{
    /*
     * @url https://www.hackerrank.com/challenges/2d-array/problem
     */
    public static class TwoDArrayDS
    {
        public static int hourglassSum(int[][] arr)
        {
            int hourglassWidth = 3;
            int hourglassHeight = 3;
            int hourglassThinness = 1;

            int heightLimit = arr.Length - hourglassHeight; 
            int widhtLimit = arr[0].Length - hourglassWidth;
            ICollection<int> list = new List<int>();

            for(int h = 0; h <= heightLimit; h++)
            {
                for (int w = 0; w <= widhtLimit; w++)
                {
                    int result = CalculateHourglass(arr, hourglassWidth, hourglassHeight, hourglassThinness, h, w);

                    list.Add(result);
                }
            }

            return list.Max();
        }

        private static int CalculateHourglass(int[][] arr, int hourglassWidth, int hourglassHeight, int hourglassThiness, int h, int w)
        {
            int result = 0;

            for (int i = 0; i < hourglassHeight; i++)
            {
                result += (i == 0 || i == (hourglassHeight - 1)) ? 
                    SumRow(arr, hourglassWidth, h + i, w) :
                    SumRow(arr, hourglassThiness, h + i, w + 1);
            }

            return result;
        }

        private static int SumRow(int[][] arr, int hourglassThiness, int h, int w)
        {
            int sum = 0;

            for (int i = 0; i < hourglassThiness; i++)
            {
                sum += arr[h][w + i];
            }

            return sum;
        }
    }
}
