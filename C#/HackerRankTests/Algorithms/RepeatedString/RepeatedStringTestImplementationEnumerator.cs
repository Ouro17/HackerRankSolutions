using HackerRank.Algorithms.RepeatedString;
using HackerRankTests.Utils;

namespace HackerRankTests.Algorithms.RepeatedString
{
    public class RepeatedStringTestImplementationEnumerator : ImplementationEnumerator<RepeatedStringAuthors, IRepeatedString>
    {
        private static object[] data =
        {
            new object[]
            {
               "aba",
               10L
            },
            new object[]
            {
               "a",
               1000000000000
            }
        };

        private static object[] results =
        {
            7L, 1000000000000
        };

        public RepeatedStringTestImplementationEnumerator() : base(new RepeatedStringFactory(), data, results)
        {
        }
    }
}
