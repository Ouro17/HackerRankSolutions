using HackerRank.DataStructures.Arrays.TwoDArrayDS.Implementations;
using HackerRank.Utils;
using System;

namespace HackerRank.DataStructures.Arrays.TwoDArrayDS
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

        public ITwoDArrayDS GetObject(TwoDArrayDSAuthors type, object[] parameters)
        {
            switch (type)
            {
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
