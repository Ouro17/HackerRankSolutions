using HackerRank.Algorithms.JumpingOnTheClouds;
using Xunit;

namespace HackerRankTests.Algorithms.JumpingOnTheClouds
{
    public class JumpingOnTheCloudsTest
    {
        [Theory]
        [ClassData(typeof(JumpingOnTheCloudsTestImplementationEnumerator))]
        public void JumpingOnTheClouds_HappyPath_ReturnsMin(IJumpingOnTheClouds impl, object[] data, int expectedResult)
        {
            Assert.Equal(expectedResult, impl.JumpingOnClouds((int[]) data[0]));
        }
    }
}
