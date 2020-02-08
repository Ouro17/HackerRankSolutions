using HackerRank.Algorithms.JumpingOnTheClouds;
using HackerRankTests.Utils;

namespace HackerRankTests.Algorithms.JumpingOnTheClouds
{
    public class JumpingOnTheCloudsTestImplementationEnumerator : ImplementationEnumerator<JumpingOnTheCloudsAuthors, IJumpingOnTheClouds>
    {
        private static object[] data =
        {
            new object[]
            {
                new int[]
                {
                    0, 0, 1, 0, 0, 1, 0
                }
            },
            new object[]
            {
                new int[]
                {
                    0, 0, 0, 1, 0, 0
                }
            },
        };

        private static object[] results =
        {
            4, 3
        };

        public JumpingOnTheCloudsTestImplementationEnumerator() : base(new JumpingOnTheCloudsFactory(), data, results)
        {
        }
    }
}
