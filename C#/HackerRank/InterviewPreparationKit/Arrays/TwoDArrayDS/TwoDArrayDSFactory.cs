using HackerRank.InterviewPreparationKit.Arrays.TwoDArrayDS.Implementations;
using HackerRank.Utils;
using System;

namespace HackerRank.InterviewPreparationKit.Arrays.TwoDArrayDS
{
    public class TwoDArrayDSFactory : IFactory<TwoDArrayDSAuthors, ITwoDArrayDS>
    {
        public ITwoDArrayDS GetObject(TwoDArrayDSAuthors type)
        {
            switch (type)
            {
                case TwoDArrayDSAuthors.Ouro17:
                    return new TwoDArrayDSOuro17();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
