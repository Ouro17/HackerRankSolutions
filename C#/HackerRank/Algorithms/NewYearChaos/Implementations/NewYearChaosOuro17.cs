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
                int next = ((i + 1) >= q.Length) ? q.Length + 1 : q[i + 1]; 

                if ((current - i) > 3)
                {
                    IsChaotic = true;
                }
                else
                {
                    if (current > next)
                    {
                        bribes++;
                    }
                    else if (current > (i + 1))
                    {
                        bribes++;
                    }

                    i++;
                }
            }

            // Replace TextWriter with Console if you want to test on the web.
            TextWriter.Write((IsChaotic) ? TooChaotic : bribes.ToString());
        }
    }
}
