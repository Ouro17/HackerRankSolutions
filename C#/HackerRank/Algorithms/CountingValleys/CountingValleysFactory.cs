using HackerRank.Algorithms.CountingValleys.Implementations;
using HackerRank.Utils;
using System;

namespace HackerRank.Algorithms.CountingValleys
{
    public class CountingValleysFactory : IFactory<CountingValleysAuthors, ICountingValleys>
    {
        public ICountingValleys GetObject(CountingValleysAuthors type)
        {
            switch (type)
            {
                case CountingValleysAuthors.Ouro17:
                    return new CountingValleysOuro17();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
