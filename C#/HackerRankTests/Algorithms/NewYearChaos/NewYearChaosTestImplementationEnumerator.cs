using HackerRank.Algorithms.NewYearChaos;
using HackerRank.Utils.TextWriterFactories;
using HackerRankTests.Utils;

namespace HackerRankTests.Algorithms.NewYearChaos
{
    public class NewYearChaosTestImplementationEnumerator : ImplementationEnumerator<NewYearChaosAuthors, INewYearChaos>
    {
        private static readonly object[] data =
        {
            new object[]
            {
                new int[]
                {
                    2, 1, 5, 3, 4
                }
            },
            new object[]
            {
                new int[]
                {
                    2, 5, 1, 3, 4
                }
            },
            new object[]
            {
                new int[]
                {
                    5, 1, 2, 3, 7, 8, 6, 4
                }
            },
            new object[]
            {
                new int[]
                {
                    1, 2, 5, 3, 7, 8, 6, 4
                }
            },
            new object[]
            {
                new int[]
                {
                    1, 2, 5, 3, 4, 7, 8, 6
                }
            },
        };

        private static readonly object[] results =
        {
            3,
            "Too chaotic",
            "Too chaotic",
            7,
            4
        };

        public NewYearChaosTestImplementationEnumerator() : base(new NewYearChaosFactory(new TextWriterFactory()), data, results)
        {
        }
    }
}
