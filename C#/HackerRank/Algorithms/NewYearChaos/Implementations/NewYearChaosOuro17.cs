using System.IO;
using System.Linq;

namespace HackerRank.Algorithms.NewYearChaos.Implementations
{
    public class NewYearChaosOuro17 : INewYearChaos
    {
        public NewYearChaosOuro17(TextWriter textWriter)
        {
            TextWriter = textWriter;
        }

        public TextWriter TextWriter { get; }

        public void MinimumBribes(int[] q)
        {
            const string TooChaotic = "Too chaotic";
            bool IsChaotic = false;
            int i = 0;

            int bribes = 0;

            while (!IsChaotic && i < q.Length)
            {
                int current = q[i];

                if ((current - i) > 3)
                {
                    IsChaotic = true;
                }
                else
                {
                    if ((current - 1) <= i)
                    {
                        bribes++;
                    }

                    i++;
                }
            }

            // Replace TextWriter with Console if you want to test on the web.
            TextWriter.Write((IsChaotic) ? TooChaotic : bribes.ToString());
        }

        // 1 2 3 4 5 6 7 8

        // 1 2 3 4 5 7 6 8
        // 1 2 3 5 4 7 6 8
        // 1 2 3 5 7 4 6 8
        // 1 2 3 5 7 4 8 6
        // 1 2 3 5 7 8 4 6
        // 1 2 3 5 7 8 6 4
        // 1 2 5 3 7 8 6 4 <= check diff by 2??
    }
}
