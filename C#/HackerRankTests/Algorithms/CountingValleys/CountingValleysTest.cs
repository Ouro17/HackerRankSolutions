using HackerRank.Algorithms.CountingValleys;
using Xunit;

namespace HackerRankTests.Algorithms.CountingValleys
{
    public class CountingValleys
    {
        [Theory]
        [ClassData(typeof(CountingValleysTestImplementationEnumerator))]
        public void CountingValleys_HappyPath_ReturnsNumbersOfValleys(ICountingValleys impl, object[] data, int expectedResult)
        {
            Assert.Equal(expectedResult, impl.CountingValleys((int) data[0], (string) data[1]));
        }
    }
}
