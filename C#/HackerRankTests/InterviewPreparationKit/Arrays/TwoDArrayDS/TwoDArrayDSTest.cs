using HackerRank.InterviewPreparationKit.Arrays.TwoDArrayDS;
using Xunit;

namespace HackerRankTests.InterviewPreparationKit.Arrays.TwoDArrayDS
{
    public class TwoDArrayDSTest
    {
        [Theory]
        [ClassData(typeof(TwoDArrayDSTestImplementationEnumerator))]
        public void HourglassSum_HappyPath_ReturnsMax(ITwoDArrayDS impl, int[][] data, int expectedResult)
        {
            // Assert
            Assert.Equal(expectedResult, impl.HourglassSum(data));
        }
    }
}
