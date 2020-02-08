using HackerRank.DataStructures.Arrays.TwoDArrayDS;
using Xunit;

namespace HackerRankTests.DataStructures.Arrays.TwoDArrayDS
{
    public class TwoDArrayDSTest
    {
        [Theory]
        [ClassData(typeof(TwoDArrayDSTestImplementationEnumerator))]
        public void HourglassSum_HappyPath_ReturnsMax(ITwoDArrayDS impl, int[][] data, int expectedResult)
        {
            Assert.Equal(expectedResult, impl.HourglassSum(data));
        }
    }
}
