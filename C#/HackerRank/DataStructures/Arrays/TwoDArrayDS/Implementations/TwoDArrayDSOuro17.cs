using System.Collections.Generic;
using System.Linq;

namespace HackerRank.DataStructures.Arrays.TwoDArrayDS.Implementations
{
    public class TwoDArrayDSOuro17 : ITwoDArrayDS
    {
        public const int HourglassWidth = 3;
        public const int HourglassHeight = 3;
        public const int HourglassThinness = 1;

        public int HourglassSum(int[][] arr)
        {
            ICollection<int> results = new List<int>();

            int heightLimit = arr.Length - HourglassHeight; 
            int widhtLimit = arr[0].Length - HourglassWidth;

            for(int h = 0; h <= heightLimit; h++)
            {
                for (int w = 0; w <= widhtLimit; w++)
                {
                    results.Add(CalculateHourglass(arr, HourglassWidth, HourglassHeight, HourglassThinness, h, w));
                }
            }

            return results.Max();
        }

        private int CalculateHourglass(int[][] arr, int hourglassWidth, int hourglassHeight, int hourglassThiness, int h, int w)
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

        private int SumRow(int[][] arr, int hourglassThiness, int h, int w)
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
