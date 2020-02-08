using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.SockMerchant.Implementations
{
    public class SockMerchantOuro17 : ISockMerchant
    {
        public int SockMerchant(int n, int[] ar)
        {
            IDictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int a in ar)
            {
                dict[a] = dict.TryGetValue(a, out int value) ? value + 1 : 1;
            }

            return dict.Select(e => e.Value / 2).Sum();
        }
    }
}
