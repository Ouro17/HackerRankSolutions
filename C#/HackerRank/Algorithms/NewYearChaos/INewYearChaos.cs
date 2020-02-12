using System.IO;

namespace HackerRank.Algorithms.NewYearChaos
{
    /*
     * @url https://www.hackerrank.com/challenges/new-year-chaos
     */
    public interface INewYearChaos
    {
        TextWriter TextWriter { get; }

        void MinimumBribes(int[] q);
    }
}
