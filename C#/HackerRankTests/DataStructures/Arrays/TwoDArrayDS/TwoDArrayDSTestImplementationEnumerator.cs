using HackerRank.DataStructures.Arrays.TwoDArrayDS;
using HackerRankTests.Utils;

namespace HackerRankTests.DataStructures.Arrays.TwoDArrayDS
{
    public class TwoDArrayDSTestImplementationEnumerator : ImplementationEnumerator<TwoDArrayDSAuthors, ITwoDArrayDS>
    {
        private static object[] data =
        {
            new int[][]
            {
               new int[] {1, 1, 1, 0, 0, 0},
               new int[] {0, 1, 0, 0, 0, 0},
               new int[] {1, 1, 1, 0, 0, 0},
               new int[] {0, 0, 2, 4, 4, 0},
               new int[] {0, 0, 0, 2, 0, 0},
               new int[] {0, 0, 1, 2, 4, 0}
            },
            new int[][]
            {
               new int[] {1, 1, 1, 0, 0, 0},
               new int[] {0, 1, 0, 0, 0, 0},
               new int[] {1, 1, 1, 0, 0, 0},
               new int[] {0, 9, 2, -4, -4, 0},
               new int[] {0, 0, 0, -2, 0, 0},
               new int[] {0, 0, -1, -2, -4, 0}
            }
        };

        private static object[] results =
        {
            19, 13
        };

        public TwoDArrayDSTestImplementationEnumerator() : base(new TwoDArrayDSFactory(), data, results)
        {
        }
    }
}
