using HackerRank.Algorithms.CountingValleys;
using HackerRankTests.Utils;

namespace HackerRankTests.Algorithms.CountingValleys
{
    public class CountingValleysTestImplementationEnumerator : ImplementationEnumerator<CountingValleysAuthors, ICountingValleys>
    {
        private static object[] data =
        {
            new object[]
            {
               8, "UDDDUDUU"
            },
            new object[]
            {
                12, "DDUUDDUDUUUD"
            }
        };

        private static object[] results =
        {
            1, 2
        };

        public CountingValleysTestImplementationEnumerator() : base(new CountingValleysFactory(), data, results)
        {
        }
    }
}
