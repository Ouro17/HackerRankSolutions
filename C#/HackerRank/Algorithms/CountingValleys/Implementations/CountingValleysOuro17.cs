using System.Linq;

namespace HackerRank.Algorithms.CountingValleys.Implementations
{
    public class CountingValleysOuro17 : ICountingValleys
    {
        public int CountingValleys(int n, string s)
        {
            int result = 0;
            char up = 'U';

            var steps = s.ToArray();

            int currentLevel = 0;

            foreach (char step in steps)
            {
                currentLevel += (step == up) ? 1 : -1;

                if (currentLevel == 0 && step == up)
                {
                    result++;
                }
            }

            return result;

        }
    }
}
