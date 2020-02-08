using HackerRank.Algorithms.RepeatedString;
using Xunit;

namespace HackerRankTests.Algorithms.RepeatedString
{
    public class RepeatedStringTest
    {
        [Theory]
        [ClassData(typeof(RepeatedStringTestImplementationEnumerator))]
        public void RepeatedString_HappyPath_ReturnsExpectedResult(IRepeatedString impl, object[] data, long expectedResult)
        {
            Assert.Equal(expectedResult, impl.RepeatedString((string) data[0], (long) data[1]));
        }
    }
}
