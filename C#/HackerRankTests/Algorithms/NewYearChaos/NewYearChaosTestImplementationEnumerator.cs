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
            }
        };

        private static readonly object[] results =
        {
            3,
            "Too chaotic"
        };

        public NewYearChaosTestImplementationEnumerator() : base(new NewYearChaosFactory(new TextWriterFactory()), data, results)
        {
        }
    }
}
