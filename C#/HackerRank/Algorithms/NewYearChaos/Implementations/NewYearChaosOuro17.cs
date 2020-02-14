using System;
using System.IO;

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

            while (!IsChaotic && i < (q.Length - 1))
            {
                int currentTicket = q[i];
                int nextTicket = q[i + 1];
                int currentPos = (i + 1);

                if ((currentTicket - i) > 3)
                {
                    IsChaotic = true;
                }
                else
                {
                    // 1, 2, 5, 3, 7, 8, 6, 4
                    if (currentTicket > nextTicket)
                    {
                        bribes += Math.Abs(currentTicket - currentPos);
                    }

                    i++;
                }
            }

            // Replace TextWriter with Console.WriteLine if you want to test on the web.
            TextWriter.Write(IsChaotic ? TooChaotic : bribes.ToString());
        }
    }
}
