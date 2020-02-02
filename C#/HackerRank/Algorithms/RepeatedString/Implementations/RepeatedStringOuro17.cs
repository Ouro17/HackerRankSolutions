using System.Linq;

namespace HackerRank.Algorithms.RepeatedString.Implementations
{
    public class RepeatedStringOuro17 : IRepeatedString
    {
        public long RepeatedString(string s, long n)
        {
            char a = 'a';

            char[] data = s.ToArray();

            long rest = n % data.Length;

            long result = data.Count(c => c == a) * (n / data.Length);

            return rest == 0 ? result : result + RepeatedString(s.Substring(0, (int)rest), rest);
        }
    }
}
