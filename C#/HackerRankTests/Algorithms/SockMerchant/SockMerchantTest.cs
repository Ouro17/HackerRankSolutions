using HackerRank.Algorithms.SockMerchant;
using Xunit;

namespace HackerRankTests.Algorithms.SockMerchant
{
    public class SockMerchant
    {
        [Theory]
        [ClassData(typeof(SockMerchantTestImplementationEnumerator))]
        public void SockMerchant_HappyPath_ReturnsNumbersOfPairs(ISockMerchant impl, object[] data, int expectedResult)
        {
            Assert.Equal(expectedResult, impl.SockMerchant((int) data[0], (int[]) data[1]));
        }
    }
}
