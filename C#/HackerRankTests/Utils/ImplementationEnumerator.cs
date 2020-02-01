using HackerRank.Utils;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTests.Utils
{
    public abstract class ImplementationEnumerator<TEnum, TInterface> : IImplementationEnumerator<TEnum, TInterface>
    {
        private readonly IFactory<TEnum, TInterface> _factory;
        private readonly object[] _testData;
        private readonly object[] _testResults;

        public ImplementationEnumerator(IFactory<TEnum, TInterface> factory, object[] testData, object[] testResults)
        {
            _factory = factory;
            _testData = testData;
            _testResults = testResults;
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (TEnum e in EnumUtil.GetValues<TEnum>())
            {
                foreach(var test in _testData.Select((value, index) => new { value, expectedResult = _testResults[index] }))
                {
                    yield return new object[] { _factory.GetObject(e), test.value, test.expectedResult };
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
