using HackerRank.Algorithms.SockMerchant;
using HackerRankTests.Utils;

namespace HackerRankTests.Algorithms.SockMerchant
{
    public class SockMerchantTestImplementationEnumerator : ImplementationEnumerator<SockMerchantAuthors, ISockMerchant>
    {
        private static object[] data =
        {
            new object[]
            {
               9,
               new int[]
               {
                   10, 20, 20, 10, 10, 30, 50, 10, 20
               }
            },
            new object[]
            {
                10,
                new int[]
                {
                    1, 1, 3, 1, 2, 1, 3, 3, 3, 3
                }
            }
        };

        private static object[] results =
        {
            3, 4
        };

        public SockMerchantTestImplementationEnumerator() : base(new SockMerchantFactory(), data, results)
        {
        }
    }
}
