using HackerRank.Interview_Preparation_Kit;
using Xunit;

namespace HackerRankTests.Interview_Preparation_Kit
{
    public class TwoDArrayDSTest
    {
        [Fact]
        public void hourglassSum_HappyPath_ReturnsMax()
        {
            // Arrange
            int[][] data = {
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 1, 0, 0, 0, 0},
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 0, 2, 4, 4, 0},
                new int[] {0, 0, 0, 2, 0, 0},
                new int[] {0, 0, 1, 2, 4, 0}
            };

            //Act
            int result = TwoDArrayDS.hourglassSum(data);

            // Assert
            Assert.Equal(19, result);
        }
    }
}
