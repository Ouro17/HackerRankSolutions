using System.IO;
using HackerRank.Algorithms.NewYearChaos;
using HackerRank.Utils;
using Xunit;

namespace HackerRankTests.Algorithms.NewYearChaos
{
    public class NewYearChaosTest
    {
        [Theory]
        [ClassData(typeof(NewYearChaosTestImplementationEnumerator))]
        public void NewYearChaos_HappyPath_ReturnsExpectedResult(INewYearChaos impl, object[] data, object expectedResult)
        {
            impl.MinimumBribes((int[])data[0]);

            Assert.Equal(expectedResult.ToString(), impl.TextWriter.ToString());
        }
    }
}
