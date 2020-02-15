using System;
using System.IO;

namespace HackerRank.Algorithms.NewYearChaos.Implementations
{
    public class NewYearChaosOuro17 : INewYearChaos
    {
        public TextWriter TextWriter { get; }

        public NewYearChaosOuro17(TextWriter textWriter)
        {
            TextWriter = textWriter;
        }

        public void MinimumBribes(int[] q)
        {
            const string TooChaotic = "Too chaotic";
            const int MaxBribes = 2;

            int bribes = 0;

            bool isChaotic = false;
            int i = q.Length - 1;
            int current;

            while (!isChaotic && i >= 0)
            {
                current = q[i];

                if ((current - (i + 1)) > MaxBribes)
                {
                    isChaotic = true;
                }
                else
                {
                    for (int j = Math.Max(0, current - MaxBribes); j < i; ++j)
                    {
                        if (q[j] > current)
                        {
                            bribes++;
                        }
                    }

                    --i;
                }
            }

            // Replace TextWriter with Console.WriteLine if you want to test on the web.
            TextWriter.Write(isChaotic ? TooChaotic : bribes.ToString());
        }
    }
}
