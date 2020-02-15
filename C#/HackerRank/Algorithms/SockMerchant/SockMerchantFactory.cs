using HackerRank.Algorithms.SockMerchant.Implementations;
using HackerRank.Utils;
using System;

namespace HackerRank.Algorithms.SockMerchant
{
    public class SockMerchantFactory : IFactory<SockMerchantAuthors, ISockMerchant>
    {
        public ISockMerchant GetObject(SockMerchantAuthors type)
        {
            switch (type)
            {
                case SockMerchantAuthors.Ouro17:
                    return new SockMerchantOuro17();
                default:
                    throw new NotSupportedException();
            }
        }

        public ISockMerchant GetObject(SockMerchantAuthors type, object[] parameters)
        {
            switch (type)
            {
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
